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
            => topCommand.To((s, p) => new FromCommand(s, p, schema, table));

        /// <summary>
        /// Add From to query
        /// </summary>
        /// <param name="topCommand">Top Command Instance</param>
        /// <param name="table">Table name</param>
        /// <returns></returns>
        public static IFromCommand From(this ITopCommand topCommand, string table)
            => topCommand.To((s, p) => new FromCommand(s, p, table));
    }
}