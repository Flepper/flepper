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
        /// <param name="values">Values</param>
        /// <returns></returns>
        IValuesOperator Values(params object[] values);
    }
}
