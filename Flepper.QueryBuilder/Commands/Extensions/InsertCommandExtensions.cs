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
        /// <param name="command">Insert Command instance</param>
        /// <param name="values">Values to insert</param>
        /// <returns></returns>
        public static IValuesOperator Values(this IInsertIntoCommand command, params object[] values)
            => command.To<ValuesOperator>().Values(values);
    }
}
