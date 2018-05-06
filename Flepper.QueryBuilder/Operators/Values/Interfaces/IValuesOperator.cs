using System;

namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Values Operator Interface
    /// </summary>
    public interface IValuesOperator : IQueryCommand
    {
        /// <summary>
        /// Values Operator Contract
        /// </summary>
        /// <param name="values">Array of values</param>
        /// <returns></returns>
        IValuesOperator Values(params object[] values);

        /// <summary>
        /// Values Operator Contract
        /// </summary>
        /// <param name="query">IQueryCommand</param>
        /// <returns></returns>
        IValuesOperator Values(Func<IQueryCommand, IQueryCommand> query);
    }
}
