using System;

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
        /// <param name="column">Column name</param>
        /// <param name="value">Value to update</param>
        /// <returns></returns>
        public static ISetOperator Set(this IUpdateCommand updateCommand, string column, string value)
            => updateCommand.To<SetOperator>().Set(column, value);

        /// <summary>
        /// Add Set to query
        /// </summary>
        /// <param name="updateCommand">Update Command instance</param>
        /// <param name="column">Column name</param>
        /// <param name="value">Value to update</param>
        /// <returns></returns>
        public static ISetOperator Set(this IUpdateCommand updateCommand, string column, int value)
            => updateCommand.To<SetOperator>().Set(column, value);

        /// <summary>
        /// Add Set to query
        /// </summary>
        /// <param name="updateCommand">Update Command instance</param>
        /// <param name="column">Column name</param>
        /// <param name="value">Value to update</param>
        /// <returns></returns>
        public static ISetOperator Set(this IUpdateCommand updateCommand, string column, DateTime value)
            => updateCommand.To<SetOperator>().Set(column, value);
    }
}
