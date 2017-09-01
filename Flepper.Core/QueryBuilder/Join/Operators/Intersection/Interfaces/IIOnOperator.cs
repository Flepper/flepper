namespace Flepper.Core.QueryBuilder
{
    public interface IIOnOperator
    {
        void On(string tableAlias, string column);
    }
}
