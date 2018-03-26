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
        public static ISelectCommand Select(params SqlColumn[] columns)
            => new QueryBuilder().SelectCommand(columns);

	    /// <summary>
	    /// Create Select Command
	    /// </summary>
	    /// <param name="columns">Columns name</param>
	    /// <returns></returns>
	    public static ISelectCommand Select(string[] columns)
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
        /// <param name="columns">SqlColumn arrays. The column name</param>
        /// <typeparam name="T">Object</typeparam>
        /// <returns>a QueryBuilder instance</returns>
        public static ISelectCommand Select<T>(params SqlColumn[] columns) where T : class
            => new QueryBuilder().SelectCommand<T>(columns);


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

        /// <summary>
        /// Create Select Command
        /// </summary>
        /// <param name="columns">SqlColumn arrays. The column name</param>
        /// <returns>a QueryBuilder instance</returns>
        public static ISelectCommand SelectWithDistinct(params SqlColumn[] columns)
            => new QueryBuilder().SelectCommandWithDistinct(columns);

        /// <summary>
        /// Create SoftDelete Command
        /// </summary>
        /// <typeparam name="T">class type that contain the flag</typeparam>
        /// <param name="table">Table name</param>
        /// <returns></returns>
        public static ISoftDeleteCommand SoftDelete<T>(string table) where T : class
            => new QueryBuilder().SoftDeleteCommand<T>(table);

        /// <summary>
        /// Create SoftDelete command using the class name as table name 
        /// </summary>
        /// <typeparam name="T">class type that contain the flag</typeparam>
        /// <returns></returns>
        public static ISoftDeleteCommand SoftDelete<T>() where T : class
                    => new QueryBuilder().SoftDeleteCommand<T>();

        /// <summary>
        /// Create QueryBuilderParamenter
        /// </summary>
        /// <typeparam name="T">class type that contain the flag</typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static QueryBuilderParameter NullValue<T>(T? value = default) where T : struct
            => new QueryBuilderParameter<T>(value);

        /// <summary>
        /// Create QueryBuilderParamenter
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static QueryBuilderParameter NullValueString(string value = null)
            => new QueryBuilderParameterString(value); 

    }
}
