namespace Flepper.Core.QueryBuilder
{
    public interface ISelectCommand
    {
        ISelectCommand Select();
        ISelectCommand Select(params string[] columns);
    }
}