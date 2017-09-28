using System;
using System.Linq.Expressions;

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
            => new QueryBuilder().SelectCommand();

        /// <summary>
        /// Create Select Command
        /// </summary>
        /// <param name="columns">Columns name</param>
        /// <returns></returns>
        public static ISelectCommand Select(params string[] columns)
            => new QueryBuilder().SelectCommand(columns);

        /// <summary>
        /// Create Select Command
        /// </summary>
        /// <typeparam name="T">Object</typeparam>
        /// <returns></returns>
        public static ISelectCommand Select<T>() where T : class
            => new QueryBuilder().SelectCommand<T>();

        /// <summary>
        /// Create Select Command
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static ISelectCommand Select<T>(Expression<Func<T, object>> expression) where T : class
            => new QueryBuilder().SelectCommand(expression);

        /// <summary>
        /// Create Insert Command
        /// </summary>
        /// <returns></returns>
        public static IInsertCommand Insert()
            => new QueryBuilder();

        /// <summary>
        /// Create Delete Command
        /// </summary>
        /// <returns></returns>
        public static IDeleteCommand Delete()
            => new QueryBuilder().DeleteCommand();

        /// <summary>
        /// Create Update Command
        /// </summary>
        /// <param name="table">Table name</param>
        /// <returns></returns>
        public static IUpdateCommand Update(string table)
            => new QueryBuilder().UpdateCommand(table);

        /// <summary>
        /// Create Update Command
        /// </summary>
        /// <param name="schema">Schema nem</param>
        /// <param name="table">Table name</param>
        /// <returns></returns>
        public static IUpdateCommand Update(string schema, string table)
            => new QueryBuilder().UpdateCommand(schema, table);
    }
}
