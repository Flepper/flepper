namespace Flepper.Core.QueryBuilder.Join.Operators.Comparison.Interfaces
{
    public interface IJoinComparisonOperators
    {
        void Equal(string column, string tableAlias);
        void NotEqual(string column, string tableAlias);
    }
}