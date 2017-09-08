namespace Flepper.Core.QueryBuilder
{
    public interface IComparisonOperators
    {
        void EqualTo(object value);
        void GreaterThan(int value);
        void LessThan(int value);
        void GreaterThanOrEqualTo(int value);
        void LessThanOrEqualTo(int value);
        void NotEqualTo(object value);
    }
}