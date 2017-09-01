namespace Flepper.Core.QueryBuilder.Join.Operators.Comparison.Interfaces
{
    public interface IJoinComparisonOperators
    {
        void Equal(string column);
        void NotEqual(string column);
    }
}