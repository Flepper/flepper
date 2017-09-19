namespace Flepper.QueryBuilder
{
    internal partial class QueryBuilder : IDeleteCommand
    {
        public IDeleteCommand DeleteCommand()
        {
            Command.Append("DELETE ");
            return this;
        }
    }
}
