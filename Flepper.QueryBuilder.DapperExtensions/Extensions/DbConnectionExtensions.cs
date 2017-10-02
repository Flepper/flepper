using System;
using System.Data;
using System.Linq.Expressions;

namespace Flepper.QueryBuilder.DapperExtensions
{
    public static class DbConnectionExtensions
    {
        /// <summary>
        /// Create Select Command
        /// </summary>
        /// <param name="dbConnection">DbConnection Instance</param>
        /// <returns></returns>
        public static ISelectCommand Select(this IDbConnection dbConnection)
            => new FlepperDapperQuery(dbConnection).SelectCommand();

        /// <summary>
        /// Create Select Command
        /// </summary>
        /// <param name="columns">Columns name</param>
        /// <param name="dbConnection">DbConnection Instance</param>
        /// <returns></returns>
        public static ISelectCommand Select(this IDbConnection dbConnection, params string[] columns)
            => new FlepperDapperQuery(dbConnection).SelectCommand(columns);

        /// <summary>
        /// Create Select Command
        /// </summary>
        /// <param name="dbConnection">DbConnection Instance</param>
        /// <typeparam name="T">Object</typeparam>
        /// <returns></returns>
        public static ISelectCommand Select<T>(this IDbConnection dbConnection) where T : class
            => new FlepperDapperQuery(dbConnection).SelectCommand<T>();

        /// <summary>
        /// Create Select Command
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="dbConnection">DbConnection Instance</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static ISelectCommand Select<T>(this IDbConnection dbConnection, Expression<Func<T, object>> expression) where T : class
            => new FlepperDapperQuery(dbConnection).SelectCommand(expression);

        /// <summary>
        /// Create Insert Command
        /// </summary>
        /// <param name="dbConnection">DbConnection Instance</param>
        /// <returns></returns>
        public static IInsertCommand Insert(this IDbConnection dbConnection)
            => new FlepperDapperQuery(dbConnection);

        /// <summary>
        /// Create Delete Command
        /// </summary>
        /// <param name="dbConnection">DbConnection Instance</param>
        /// <returns></returns>
        public static IDeleteCommand Delete(this IDbConnection dbConnection)
            => new FlepperDapperQuery(dbConnection).DeleteCommand();

        /// <summary>
        /// Create Update Command
        /// </summary>
        /// <param name="table">Table name</param>
        /// <param name="dbConnection">DbConnection Instance</param>
        /// <returns></returns>
        public static IUpdateCommand Update(this IDbConnection dbConnection, string table)
            => new FlepperDapperQuery(dbConnection).UpdateCommand(table);

        /// <summary>
        /// Create Update Command
        /// </summary>
        /// <param name="schema">Schema nem</param>
        /// <param name="table">Table name</param>
        /// <param name="dbConnection">DbConnection Instance</param>
        /// <returns></returns>
        public static IUpdateCommand Update(this IDbConnection dbConnection, string schema, string table)
            => new FlepperDapperQuery(dbConnection).UpdateCommand(schema, table);


    }
}
