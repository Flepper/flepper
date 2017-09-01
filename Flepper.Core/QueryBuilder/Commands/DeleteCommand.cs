using Flepper.Core.Base;

namespace Flepper.Core.QueryBuilder
{
    public class DeleteCommand : BaseFlepperQueryBuilder, IDeleteCommand
    {
        public IDeleteCommand Delete()
        {
            BeforeExecute();

            Command.Append("DELETE ");

            return this;
        }
    }
}
