namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Top Command Extensions
    /// </summary>
    public static class TopCommandExtensions
    {
        /// <summary>
        /// Add From to query
        /// </summary>
        /// <param name="topCommand">Top Command Instance</param>
        /// <param name="schema">Schema name</param>
        /// <param name="table">Table name</param>
        /// <returns></returns>
        public static IFromCommand From(this ITopCommand topCommand, string schema, string table)
            => topCommand is IFromCommand command ? command.FromCommand(schema, table) : null;

        /// <summary>
        /// Add From to query
        /// </summary>
        /// <param name="topCommand">Top Command Instance</param>
        /// <param name="table">Table name</param>
        /// <returns></returns>
        public static IFromCommand From(this ITopCommand topCommand, string table)
            => topCommand is IFromCommand command ? command.FromCommand(table) : null;
    }
}