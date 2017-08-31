namespace Flepper.Core.QueryBuilder.Commands.Interfaces
{
    public interface IFromCommand
    {
        IFromCommand From(string schema, string table);
        IFromCommand From(string table);
    }
}