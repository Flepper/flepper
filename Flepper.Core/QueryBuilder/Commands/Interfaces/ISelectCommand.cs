namespace Flepper.Core.QueryBuilder.Commands.Interfaces
{
    public interface ISelectCommand
    {
        ISelectCommand Select();
        ISelectCommand Select(params string[] columns);
    }
}