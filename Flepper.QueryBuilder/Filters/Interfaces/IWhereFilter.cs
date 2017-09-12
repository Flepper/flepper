namespace Flepper.QueryBuilder
{
    public interface IWhereFilter : IQueryCommand
    {
        IWhereFilter Where(string field);
        IWhereFilter Where(string tableAlias, string field);
    }
}
