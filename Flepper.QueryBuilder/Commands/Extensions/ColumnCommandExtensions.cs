using Flepper.QueryBuilder.Operators.SqlFunctions.Interfaces;

namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Column Command extension class
    /// </summary>
    public static class ColumnCommandExtensions
    {
        ///// <summary>
        ///// Add Count Function to query
        ///// </summary>
        ///// <param name="selectCommand"></param>
        ///// <param name="sqlFunction"></param>
        ///// <returns></returns>
        //public static IColumnCommand Column(this ISelectCommand selectCommand, ISqlFunction sqlFunction)
        //    => selectCommand.To((s, p) => new ColumnCommand(s,p,sqlFunction));


        /// <summary>
        /// Add From to query
        /// </summary>
        /// <param name="selectCommand">Select Command Extension</param>
        /// <param name="schema">Schema name</param>
        /// <param name="table">Table name</param>
        /// <returns></returns>
        public static IFromCommand From(this IColumnCommand selectCommand, string schema, string table)
            => selectCommand.To((s, p) => new FromCommand(s, p, schema, table));


        /// <summary>
        /// Add From to query
        /// </summary>
        /// <param name="selectCommand">Select Command Instance</param>
        /// <param name="table">Table name</param>
        /// <returns></returns>
        public static IFromCommand From(this IColumnCommand selectCommand, string table)
            => selectCommand.To((s, p) => new FromCommand(s, p, table));
    }
}
