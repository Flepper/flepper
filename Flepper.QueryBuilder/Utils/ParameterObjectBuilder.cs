using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

namespace Flepper.QueryBuilder.Utils
{
    internal static class ParameterObjectBuilder
    {
        const MethodAttributes METHOD_ATTRIBUTES = MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.HideBySig;

        private static readonly ModuleBuilder ModuleBuilder;
        private static readonly ConcurrentDictionary<string, Type> Types = new ConcurrentDictionary<string, Type>();

        static ParameterObjectBuilder()
        {
            var assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName("Flepper.ParameterObjects"), AssemblyBuilderAccess.RunAndCollect);
            ModuleBuilder = assemblyBuilder.DefineDynamicModule("MainModule");
        }

        public static object CreateObjectWithValues(IDictionary<string, object> parameters)
        {
            object obj = null;

            if (parameters.Any() == false) goto end;

            var objType = CreateClass(parameters);
            obj = Activator.CreateInstance(objType);
            foreach (var prop in objType.GetProperties())
                prop.SetValue(obj, GetValueParameter(parameters[$"@{prop.Name}"]));

            end:

            return obj;
        }

        internal static Type CreateClass(IDictionary<string, object> parameters, string className = null)
        {
            if (string.IsNullOrWhiteSpace(className) == false && Types.ContainsKey(className))
                return Types[className];

            var typeBuilder = ModuleBuilder.DefineType(className ?? Guid.NewGuid().ToString(), TypeAttributes.Public | TypeAttributes.Class | TypeAttributes.AutoClass | TypeAttributes.AnsiClass | TypeAttributes.BeforeFieldInit | TypeAttributes.AutoLayout, null);
            typeBuilder.DefineDefaultConstructor(MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName);           
            foreach (var parameter in parameters)            
                CreateProperty(typeBuilder, parameter.Key.Replace("@", ""), GetTypeParameter(parameter));            
            var type = typeBuilder.CreateTypeInfo().AsType();
            Types.TryAdd(type.FullName, type);
            return type;
        }       

        internal static Type GetTypeParameter(KeyValuePair<string, object> parameter)
        {
            var value = parameter.Value;
            return value is QueryBuilderParameter queryParameter
                    ? queryParameter.ParameterType
                    : value.GetType();
        }

        internal static object GetValueParameter(object value)
        {            
            return value is QueryBuilderParameter queryParameter
                    ? queryParameter.Value
                    : value;
        }

        private static PropertyBuilder CreateProperty(TypeBuilder typeBuilder, string propertyName, Type propertyType)
        {
            var fieldBuilder = typeBuilder.DefineField("_" + propertyName, propertyType, FieldAttributes.Private);

            var propBuilder = typeBuilder.DefineProperty(propertyName, PropertyAttributes.HasDefault, propertyType, null);
            propBuilder.SetGetMethod(DefineGet(typeBuilder, fieldBuilder, propBuilder));
            propBuilder.SetSetMethod(DefineSet(typeBuilder, fieldBuilder, propBuilder));

            return propBuilder;
        }

        private static MethodBuilder DefineSet(TypeBuilder typeBuilder, FieldBuilder fieldBuilder, PropertyBuilder propBuilder)
            => DefineMethod(typeBuilder, $"set_{propBuilder.Name}", null, new[] { propBuilder.PropertyType }, il =>
              {
                  il.Emit(OpCodes.Ldarg_0);
                  il.Emit(OpCodes.Ldarg_1);
                  il.Emit(OpCodes.Stfld, fieldBuilder);
                  il.Emit(OpCodes.Ret);
              });

        private static MethodBuilder DefineGet(TypeBuilder typeBuilder, FieldBuilder fieldBuilder, PropertyBuilder propBuilder)
            => DefineMethod(typeBuilder, $"get_{propBuilder.Name}", propBuilder.PropertyType, Type.EmptyTypes, il =>
            {
                il.Emit(OpCodes.Ldarg_0);
                il.Emit(OpCodes.Ldfld, fieldBuilder);
                il.Emit(OpCodes.Ret);
            });

        private static MethodBuilder DefineMethod(TypeBuilder typeBuilder, string methodName, Type propertyType, Type[] parameterTypes, Action<ILGenerator> bodyWriter)
        {
            var methodBuilder = typeBuilder.DefineMethod(methodName, METHOD_ATTRIBUTES, propertyType, parameterTypes);
            bodyWriter(methodBuilder.GetILGenerator());
            return methodBuilder;
        }

        public static Type GetTypeFromName(string className)
            => Types.ContainsKey(className) ? Types[className] : null;
    }
}
