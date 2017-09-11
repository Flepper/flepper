namespace Flepper.QueryBuilder
{
    public interface IWhereFilter
    {
        void Where(string field);
        void Where(string tableAlias, string field);
    }
}
