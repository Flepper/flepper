namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Set Operator Extensions
    /// </summary>
    public static class SetOperatorExtensions
    {
        /// <summary>
        /// Add Where to query
        /// </summary>
        /// <param name="fromCommand">From Command instance</param>
        /// <param name="field">Column Name</param>
        /// <returns></returns>
        public static IWhereFilter Where(this ISetOperator fromCommand, string field)
            => fromCommand is IWhereFilter command ? command.Where(field) : null;
    }
}
