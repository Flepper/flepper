using System;
using System.Linq.Expressions;
using Flepper.QueryBuilder.Base;
using Flepper.QueryBuilder.Utils;

namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Flepper Query Builder Public API
    /// </summary>
    public static class FlepperQueryBuilder
    {
        /// <summary>
        /// Create Select Command
        /// </summary>
        /// <returns></returns>
        public static ISelectCommand Select()
            => new BaseQueryBuilder().SelectCommand();

        /// <summary>
        /// Create Select Command
        /// </summary>
        /// <param name="columns">Columns name</param>
        /// <returns></returns>
        public static ISelectCommand Select(params string[] columns)
            => new BaseQueryBuilder().SelectCommand(columns);

        /// <summary>
        /// Create Select Command
        /// </summary>
        /// <typeparam name="T">Object</typeparam>
        /// <returns></returns>
        public static ISelectCommand Select<T>() where T : class
            => new BaseQueryBuilder().SelectCommand(Cache.GetTypeProperties<T>());

        /// <summary>
        /// Create Select Command
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static ISelectCommand Select<T>(Expression<Func<T, object>> expression) where T : class
            => new BaseQueryBuilder().SelectCommand(Cache.GetPropertiesFromExpression<T>(expression));

        /// <summary>
        /// Create Insert Command
        /// </summary>
        /// <returns></returns>
        public static IInsertCommand Insert()
            => new BaseQueryBuilder();

        /// <summary>
        /// Create Delete Command
        /// </summary>
        /// <returns></returns>
        public static IDeleteCommand Delete()
            => new BaseQueryBuilder().DeleteCommand();

        /// <summary>
        /// Create Update Command
        /// </summary>
        /// <param name="table">Table name</param>
        /// <returns></returns>
        public static IUpdateCommand Update(string table)
            => new BaseQueryBuilder().UpdateCommand(table);

        /// <summary>
        /// Create Update Command
        /// </summary>
        /// <param name="schema">Schema nem</param>
        /// <param name="table">Table name</param>
        /// <returns></returns>
        public static IUpdateCommand Update(string schema, string table)
            => new BaseQueryBuilder().UpdateCommand(schema, table);
    }
}
