using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Configuration to advanced settings related the commands
    /// </summary>
    public static class AdvancedSettings
    {
        private static IDictionary<string, string> _modelsWithSoftDeleteEnabled =
             _modelsWithSoftDeleteEnabled = new Dictionary<string, string>();

        /// <summary>
        /// used to define the property that going to be used by softdelete command
        /// </summary>
        /// <typeparam name="TClass">The class that you want to enable</typeparam>
        /// <param name="expression">expression used to chose the property in the class</param>
        public static void EnableSoftDelete<TClass>(Expression<Func<TClass, object>> expression) where TClass : class
        {
            var unaryExpression = (UnaryExpression)expression.Body;
            var modelName = typeof(TClass).Name;

            var proepryName = GetPropertyName(unaryExpression);

            _modelsWithSoftDeleteEnabled.Add(modelName, proepryName);
        }

        private static string GetPropertyName(UnaryExpression expression)
        {
            var methodCallExpression = (MemberExpression)expression.Operand;
            var proepryName = methodCallExpression.Member.Name;
            return proepryName;
        }

        /// <summary>
        /// Get the column
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        internal static string GetColumn(string key)
            => _modelsWithSoftDeleteEnabled[key];

        /// <summary>
        /// reset configuration 
        /// </summary>
        public static void ResetSoftDeleteConfiguration()
            => _modelsWithSoftDeleteEnabled = new Dictionary<string, string>();
       
    }
}
