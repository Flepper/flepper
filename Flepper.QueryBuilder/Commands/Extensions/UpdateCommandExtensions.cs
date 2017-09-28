namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Update Command Extension
    /// </summary>
    public static class UpdateCommandExtensions
    {
        /// <summary>
        /// Add Set to query
        /// </summary>
        /// <param name="updateCommand">Update Command instance</param>
        /// <param name="column">Column name to be updated</param>
        /// <param name="value">Value to be update</param>
        /// <returns></returns>
        public static ISetOperator Set(this IUpdateCommand updateCommand, string column, string value)
            => updateCommand is ISetOperator command ? command.Set(column, value) : null; 

        /// <summary>
        /// Add Set to query
        /// </summary>
        /// <param name="updateCommand">Update Command instance</param>
        /// <param name="column">Column name to be updated</param>
        /// <param name="value">Value to be update</param>
        /// <returns></returns>
        public static ISetOperator Set(this IUpdateCommand updateCommand, string column, int value)
            => updateCommand is ISetOperator command ? command.Set(column, value) : null;

        /// <summary>
        /// Add Set to query
        /// </summary>
        /// <param name="updateCommand">Update Command instance</param>
        /// <param name="column">Column name to be updated</param>
        /// <param name="value">Value to be update</param>
        /// <returns></returns>
        public static ISetOperator Set(this IUpdateCommand updateCommand, string column, DateTime value)
            => updateCommand is ISetOperator command ? command.Set(column, value) : null;
    }
}
