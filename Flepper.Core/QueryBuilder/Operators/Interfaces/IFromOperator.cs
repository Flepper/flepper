namespace Flepper.Core.QueryBuilder.Operators.Interfaces
{
    public interface IFromOperator
    {
        void From(string schema, string table);
        void From(string table);
    }
}