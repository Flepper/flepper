namespace Flepper.QueryBuilder
{
    public interface IIOnOperator : IQueryCommand
    {
        IIOnOperator On(string tableAlias, string column);
    }
}
