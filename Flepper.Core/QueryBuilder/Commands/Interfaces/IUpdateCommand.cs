namespace Flepper.Core.QueryBuilder
{
    public interface IUpdateCommand
    {
        IUpdateCommand Update(string table);
        IUpdateCommand Update(string schema, string table);
    }
}