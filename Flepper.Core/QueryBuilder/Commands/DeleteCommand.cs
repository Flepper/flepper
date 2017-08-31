using Flepper.Core.Base;
using Flepper.Core.QueryBuilder.Commands.Interfaces;

namespace Flepper.Core.QueryBuilder.Commands
{
    public class DeleteCommand : BaseFlepperQueryBuilder, IDeleteCommand
    {
        public IDeleteCommand Delete()
        {
            Command.Append("DELETE ");
            return this;
        }
    }
}
