namespace Flepper.QueryBuilder
{
    public interface IUpdateCommand
    {
        IUpdateCommand Update(string table);
        IUpdateCommand Update(string schema, string table);
    }
}