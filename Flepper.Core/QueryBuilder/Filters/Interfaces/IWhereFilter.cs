namespace Flepper.Core.QueryBuilder.Filters.Interfaces
{
    public interface IWhereFilter
    {
        void Where(string field);
        void Where(string tableAlias, string field);
    }
}
