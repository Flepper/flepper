namespace Flepper.Core.QueryBuilder
{
    public interface IJoin
    {
        void Inner(string table);
        void Left(string table);
    }
}
