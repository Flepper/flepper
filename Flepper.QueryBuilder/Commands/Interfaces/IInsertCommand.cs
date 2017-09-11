namespace Flepper.QueryBuilder
{
    public interface IInsertCommand
    {
        IInsertCommand Insert(string table);
        IInsertCommand Insert(string table, string[] columns);
    }
}
