namespace Flepper.Core.QueryBuilder
{
    public interface IComparisonOperators
    {
        void EqualTo(string value);
        void EqualTo(int value);
        void GreaterThan(int value);
        void LessThan(int value);
        void GreaterThanOrEqualTo(int value);
        void LessThanOrEqualTo(int value);
        void NotEqualTo(int value);
        void NotEqualTo(string value);
    }
}