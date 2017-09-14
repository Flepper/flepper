using System;
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

        static ParameterObjectBuilder()
        {
            var assembly = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName("Flepper.ParameterObjects"), AssemblyBuilderAccess.Run);
            ModuleBuilder = assembly.DefineDynamicModule("MainModule");
        }

        public static object CreateObject(IDictionary<string, object> parameters)
        {
            var type = ModuleBuilder.DefineType(Guid.NewGuid().ToString(), TypeAttributes.Public | TypeAttributes.Class | TypeAttributes.AutoClass | TypeAttributes.AnsiClass | TypeAttributes.BeforeFieldInit | TypeAttributes.AutoLayout, null);
            type.DefineDefaultConstructor(MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName);
            var propertiesAndValues = (from parameter in parameters
                                       let parameterValue = parameter.Value
                                       let propertyType = parameterValue.GetType()
                                       let property = CreateProperty(type, parameter.Key.Replace("@", ""), propertyType)
                                       select (property: property.Name, parameterValue: parameterValue))
                                       .ToDictionary(t => t.property, t => t.parameterValue);
            var objType = type.CreateTypeInfo().AsType();
            var obj = Activator.CreateInstance(objType);
            foreach (var prop in objType.GetProperties())
                prop.SetValue(obj, propertiesAndValues[prop.Name]);

            return obj;
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
    }
}
