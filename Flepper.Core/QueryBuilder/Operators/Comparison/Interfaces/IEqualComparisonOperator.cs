namespace Flepper.Core.QueryBuilder.Operators.Comparison.Interfaces
{
    public interface IEqualComparisonOperator
    {
        void Equal(string value);
        void Equal(int value);
    }
}