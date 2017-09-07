namespace Flepper.Core.QueryBuilder.Commands.Interfaces
{
    public interface IInsertCommand
    {
        IInsertCommand Insert(string table);
        IInsertCommand Insert(string table, string[] columns);
    }
}
