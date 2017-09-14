namespace Flepper.QueryBuilder
{
    public interface IInsertCommand : IQueryCommand
    {
        IInsertIntoCommand Into(string table);
    }
}
