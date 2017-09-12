namespace Flepper.QueryBuilder
{
    public interface IJoin : IQueryCommand
    {
        IJoin InnerJoin(string table);
        IJoin LeftJoin(string table);
    }
}
