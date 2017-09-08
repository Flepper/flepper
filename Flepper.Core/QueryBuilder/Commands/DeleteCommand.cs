using Flepper.Core.Base;

namespace Flepper.Core.QueryBuilder
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
