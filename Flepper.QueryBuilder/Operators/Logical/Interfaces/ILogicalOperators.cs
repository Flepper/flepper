namespace Flepper.QueryBuilder
{
    public interface ILogicalOperators : IQueryCommand
    {
        ILogicalOperators And(string column);
        ILogicalOperators Or(string column);
    }
}