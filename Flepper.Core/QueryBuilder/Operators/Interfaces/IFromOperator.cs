namespace Flepper.Core.QueryBuilder.Operators.Interfaces
{
    public interface IFromOperator
    {
        IFromOperator From(string schema, string table);
        IFromOperator From(string table);
    }
}