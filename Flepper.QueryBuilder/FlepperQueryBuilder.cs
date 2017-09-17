using System;
using System.Linq.Expressions;
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
            => new SelectCommand();

        /// <summary>
        /// Create Select Command
        /// </summary>
        /// <param name="columns">Columns name</param>
        /// <returns></returns>
        public static ISelectCommand Select(params string[] columns)
            => new SelectCommand(columns);

        /// <summary>
        /// Create Select Command
        /// </summary>
        /// <typeparam name="T">Object</typeparam>
        /// <returns></returns>
        public static ISelectCommand Select<T>() where T : class
            => new SelectCommand(Cache.GetDtoProperties<T>());

        /// <summary>
        /// Create Select Command
        /// </summary>
        /// <typeparam name="T">Object</typeparam>
        /// <returns></returns>
        public static ISelectCommand Select<T>(Expression<Func<T, object>> newExpression) where T : class
            => new SelectCommand(Cache.GetPropertiesFromExpression(newExpression));

        /// <summary>
        /// Create Insert Command
        /// </summary>
        /// <returns></returns>
        public static IInsertCommand Insert()
            => new InsertCommand();

        /// <summary>
        /// Create Delete Command
        /// </summary>
        /// <returns></returns>
        public static IDeleteCommand Delete()
            => new DeleteCommand();

        /// <summary>
        /// Create Update Command
        /// </summary>
        /// <param name="table">Table name</param>
        /// <returns></returns>
        public static IUpdateCommand Update(string table)
            => new UpdateCommand(table);

        /// <summary>
        /// Create Update Command
        /// </summary>
        /// <param name="schema">Schema nem</param>
        /// <param name="table">Table name</param>
        /// <returns></returns>
        public static IUpdateCommand Update(string schema, string table)
            => new UpdateCommand(schema, table);
    }
}
