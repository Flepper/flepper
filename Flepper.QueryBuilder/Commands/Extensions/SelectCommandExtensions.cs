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
            => selectCommand is IFromCommand command ? command.FromCommand(schema, table) : null;


        /// <summary>
        /// Add From to query
        /// </summary>
        /// <param name="selectCommand">Select Command Instance</param>
        /// <param name="table">Table name</param>
        /// <returns></returns>
        public static IFromCommand From(this ISelectCommand selectCommand, string table)
            => selectCommand is IFromCommand command ? command.FromCommand(table) : null;

        /// <summary>
        /// Add Top Command
        /// </summary>
        /// <param name="selectCommand">Select Command instance</param>
        /// <param name="size">Size of records</param>
        /// <returns></returns>
        public static ITopCommand Top(this ISelectCommand selectCommand, int size = 1)
            => selectCommand is ITopCommand command ? command.TopCommand(size) : null;
    }
}
