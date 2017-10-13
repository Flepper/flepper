namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Insert Command Extensions
    /// </summary>
    public static class InsertCommandExtensions
    {
        /// <summary>
        /// Add values to query
        /// </summary>
        /// <param name="insertIntoCommand">Insert Command instance</param>
        /// <param name="values">Values to insert</param>
        /// <returns></returns>
        public static IValuesOperator Values(this IInsertIntoCommand insertIntoCommand, params object[] values)
            => insertIntoCommand is IValuesOperator command ? command.Values(values) : null;
    }
}
