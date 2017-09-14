namespace Flepper.QueryBuilder
{
    public interface IInsertIntoCommand : IQueryCommand
    {
        IInsertIntoCommand Columns(params string[] columns);
    }
}