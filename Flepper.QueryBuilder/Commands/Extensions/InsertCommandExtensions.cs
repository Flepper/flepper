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

        /// <summary>
        /// Add values to query
        /// </summary>
        /// <param name="iValuesOperator">Insert Values Operator instance</param>
        /// <returns></returns>
        public static IValuesOperator WithScopeIdentity(this IValuesOperator iValuesOperator) 
            => iValuesOperator is IInsertScopeIdentity command ? command.WithScopeIdentity() : null;
    }
}
