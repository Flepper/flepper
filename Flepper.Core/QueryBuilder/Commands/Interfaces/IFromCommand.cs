namespace Flepper.Core.QueryBuilder
{
    public interface IFromCommand
    {
        IFromCommand From(string schema, string table);
        IFromCommand From(string table);
    }
}