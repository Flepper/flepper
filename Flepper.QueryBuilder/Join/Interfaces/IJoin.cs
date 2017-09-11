namespace Flepper.QueryBuilder
{
    public interface IJoin
    {
        void InnerJoin(string table);
        void LeftJoin(string table);
    }
}
