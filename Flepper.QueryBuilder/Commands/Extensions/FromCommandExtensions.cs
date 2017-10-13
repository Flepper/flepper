using Flepper.QueryBuilder.Operators.Grouping.Interfaces;

namespace Flepper.QueryBuilder
{
    /// <summary>
    /// From Command extensions
    /// </summary>
    public static class FromCommandExtensions
    {
        /// <summary>
        /// Add Where to query
        /// </summary>
        /// <param name="fromCommand">From command instance</param>
        /// <param name="column">Column name</param>
        /// <returns></returns>
        public static IWhereFilter Where(this IFromCommand fromCommand, string column)
            => fromCommand is IWhereFilter command ? command.Where(column) : null;

        /// <summary>
        /// Add Inner Join to query
        /// </summary>
        /// <param name="fromCommand">From command instance</param>
        /// <param name="table">Table name</param>
        /// <returns></returns>
        public static IJoin InnerJoin(this IFromCommand fromCommand, string table)
            => fromCommand is IJoin command ? command.InnerJoin(table) : null;

        /// <summary>
        /// Add Left Join to query
        /// </summary>
        /// <param name="fromCommand">From command instance</param>
        /// <param name="table">Table name</param>
        /// <returns></returns>
        public static IJoin LeftJoin(this IFromCommand fromCommand, string table)
            => fromCommand is IJoin command ? command.LeftJoin(table) : null;

        /// <summary>
        /// Add As to query
        /// </summary>
        /// <param name="fromCommand">From command instance</param>
        /// <param name="alias">Table alias</param>
        /// <returns></returns>
        public static IAliasOperator As(this IFromCommand fromCommand, string alias)
            => fromCommand is IAliasOperator command ? command.As(alias) : null;

        /// <summary>
        /// OrderBy to query
        /// </summary>
        /// /// <param name="sortCommand">Sort command instance</param>
        /// <param name="column">Column</param>
        /// <returns></returns>
        public static ISortThen OrderBy(this ISortCommand sortCommand, string column)
            => sortCommand is ISort command ? command.OrderBy(column) : null;

        /// <summary>
        /// OrderBy to query
        /// </summary>
        /// /// <param name="sortCommand">Sort command instance</param>
        /// <param name="tableAlias">Table Alias</param>
        /// <param name="column">Column Name</param>        
        /// <returns></returns>
        public static ISortThen OrderBy(this ISortCommand sortCommand, string tableAlias, string column)
            => sortCommand is ISort command ? command.OrderBy(tableAlias, column) : null;

        /// <summary>
        /// OrderBy Descending to query
        /// </summary>
        /// /// <param name="sortCommand">Sort command instance</param>
        /// <param name="column">Column</param>
        /// <returns></returns>
        public static ISortThen OrderByDescending(this ISortCommand sortCommand, string column)
            => sortCommand is ISort command ? command.OrderByDescending(column) : null;

        /// <summary>
        /// OrderBy Descending to query
        /// </summary>
        /// /// <param name="sortCommand">Sort command instance</param>
        /// <param name="tableAlias">Table Alias</param>
        /// <param name="column">Column Name</param>        
        /// <returns></returns>
        public static ISortThen OrderByDescending(this ISortCommand sortCommand, string tableAlias, string column)
            => sortCommand is ISort command ? command.OrderByDescending(tableAlias, column) : null;

        /// <summary>
        /// Add Group by to query
        /// </summary>
        /// <param name="fromCommand">From command stance</param>
        /// <param name="column">column used on group</param>
        public static IGrouping GroupBy(this IFromCommand fromCommand, string column)
            => fromCommand is IGrouping command ? command.GroupBy(column) : null;
    }
}