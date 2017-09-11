using Flepper.QueryBuilder.Base;

namespace Flepper.QueryBuilder
{
    internal class DeleteCommand : BaseQueryBuilder, IDeleteCommand
    {
        public IDeleteCommand Delete()
        {
            BeforeExecute();

            Command.Append("DELETE ");

            return this;
        }
    }
}
