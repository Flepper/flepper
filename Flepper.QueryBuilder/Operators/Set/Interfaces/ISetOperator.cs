using System;

namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Set Operator Interface
    /// </summary>
    public interface ISetOperator : IQueryCommand
    {
        /// <summary>
        /// Set Operator Contract
        /// </summary>
        /// <typeparam name="T">Object</typeparam>
        /// <param name="column">Column name</param>
        /// <param name="value">Value</param>
        /// <returns></returns>
        ISetOperator Set<T>(string column, T value);
    }
}