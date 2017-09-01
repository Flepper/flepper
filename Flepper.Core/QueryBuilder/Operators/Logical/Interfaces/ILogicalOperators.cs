namespace Flepper.Core.QueryBuilder
{
    public interface ILogicalOperators
    {
        void And(string column);
        void Or(string column);
    }
}