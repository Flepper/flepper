namespace Flepper.QueryBuilder
{
    public interface IValuesOperator : IQueryCommand
    {
        IValuesOperator Values(params object[] values);
    }
}
