namespace Flepper.Core.QueryBuilder.Join.Interfaces
{
    public interface IJoin
    {
        void Inner(string table);
        void Left(string table);
    }
}
