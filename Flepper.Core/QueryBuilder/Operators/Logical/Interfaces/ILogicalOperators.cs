namespace Flepper.Core.QueryBuilder.Operators.Logical.Interfaces
{
    public interface ILogicalOperators
    {
        void And(string column);
        void Or(string column);
    }
}