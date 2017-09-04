namespace Flepper.Core.QueryBuilder.Operators.Set.Interfaces
{
    public interface ISetOperator
    {
        ISetOperator Set(string column, string value);
        ISetOperator Set(string column, int value);
    }
}