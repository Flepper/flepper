namespace Flepper.Core.QueryBuilder
{
    public interface IJoinComparisonOperators
    {
        void Equal(string column, string tableAlias);
        void NotEqual(string column, string tableAlias);
    }
}