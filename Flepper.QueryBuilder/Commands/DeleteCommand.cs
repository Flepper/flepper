namespace Flepper.QueryBuilder.Base
{
    internal partial class BaseQueryBuilder : IDeleteCommand
    {
        public IDeleteCommand DeleteCommand()
        {
            Command.Append("DELETE ");
            return this;
        }
    }
}
