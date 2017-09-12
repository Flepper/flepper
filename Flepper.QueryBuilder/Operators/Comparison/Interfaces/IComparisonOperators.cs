namespace Flepper.QueryBuilder
{
    public interface IComparisonOperators : IQueryCommand
    {
        IComparisonOperators EqualTo(object value);
        IComparisonOperators GreaterThan(int value);
        IComparisonOperators LessThan(int value);
        IComparisonOperators GreaterThanOrEqualTo(int value);
        IComparisonOperators LessThanOrEqualTo(int value);
        IComparisonOperators NotEqualTo(object value);
    }
}