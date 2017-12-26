namespace Flepper.QueryBuilder
{
    /// <summary>
    /// 
    /// </summary>
    public interface IInsertScopeIdentity: IQueryCommand
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IValuesOperator WithScopeIdentity();
    }
}
