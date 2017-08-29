namespace Flepper.Core.QueryBuilder.Operators.Interfaces
{
    public interface ISelectOperator
    {
        ISelectOperator Select();
        ISelectOperator Select(params string[] columns);
    }
}