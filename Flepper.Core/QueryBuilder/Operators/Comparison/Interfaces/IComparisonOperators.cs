namespace Flepper.Core.QueryBuilder.Operators.Comparison.Interfaces
{
    public interface IComparisonOperators
    {
        void Equal(string value);
        void Equal(object value);
        void Equal(int value);
        void NotEqual(object value);
    }
}