namespace Flepper.QueryBuilder
{
    public interface IInsertCommand: IQueryCommand
    {
        IInsertCommand Into(string table);
        IInsertCommand Into(string table, params string[] columns);
    }
}
