using System;
using System.Linq.Expressions;
using Flepper.QueryBuilder.Operators.SqlFunctions;
using Flepper.QueryBuilder.Utils;

namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Flepper Query Builder Function public API
    /// </summary>
    public static class FlepperQueryFunction
    {
        /// <summary>
        /// Count Sql Function
        /// </summary>
        /// <param name="column">column used by count function</param>
        /// <param name="alias">column alias</param>
        /// <returns>string statement</returns>
        public static SqlColumn Count(string column, string alias)
            => new CountOperator(column, alias);

        /// <summary>
        /// Min Sql Function
        /// </summary>
        /// <param name="column">column used by min function</param>
        /// <param name="alias">column alias</param>
        /// <returns>sring statement</returns>
        public static SqlColumn Min(string column, string alias)
            => new MinOperator(column, alias);

        /// <summary>
        /// AsFrom Function
        /// </summary>
        /// <param name="column">column used</param>
        /// <param name="alias">alias table</param>
        /// <returns>sring statement</returns>
        public static SqlColumn AsFrom(string alias, string column)
            => new AsFromOperator(alias, column);

         /// <summary>
        /// AsFrom Function Generic
        /// </summary>
        /// <param name="alias">alias table</param>
        /// <param name="expression">object property used like column</param>
        /// <returns>sring statement</returns>
        public static SqlColumn AsFrom<T>(string alias, Expression<Func<T, object>> expression) where T : class
            => new AsFromOperator(alias, Cache.GetPropertiesFromExpression(expression)[0]);

        /// <summary>
        /// As Function
        /// </summary>
        /// <param name="column">column used</param>
        /// <param name="alias">alias column</param>
        /// <returns>sring statement</returns>
        public static SqlColumn As(string column,string alias)
            => new AsOperator(column,alias);
    }
}
