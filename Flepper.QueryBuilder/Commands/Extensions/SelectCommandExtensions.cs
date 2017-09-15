namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Select Command Extensions
    /// </summary>
    public static class SelectCommandExtensions
    {
        /// <summary>
        /// Add From to query
        /// </summary>
        /// <param name="selectCommand">Select Command Extension</param>
        /// <param name="schema">Schema name</param>
        /// <param name="table">Table name</param>
        /// <returns></returns>
        public static IFromCommand From(this ISelectCommand selectCommand, string schema, string table)
            => selectCommand.To((s, p) => new FromCommand(s, p, schema, table));


        /// <summary>
        /// Add From to query
        /// </summary>
        /// <param name="selectCommand">Select Command Instance</param>
        /// <param name="table">Table name</param>
        /// <returns></returns>
        public static IFromCommand From(this ISelectCommand selectCommand, string table)
            => selectCommand.To((s, p) => new FromCommand(s, p, table));

        /// <summary>
        /// Add Top Command
        /// </summary>
        /// <param name="selectCommand">Select Command instance</param>
        /// <param name="size">Quantity of columns</param>
        /// <returns></returns>
        public static ITopCommand Top(this ISelectCommand selectCommand, int size = 1)
            => selectCommand.To((s, p) => new TopCommand(s, p, size));
    }
}
