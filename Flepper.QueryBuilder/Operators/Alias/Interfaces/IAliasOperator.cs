namespace Flepper.QueryBuilder
{
    public interface IAliasOperator : IQueryCommand
    {
        IAliasOperator As(string alias);
    }
}