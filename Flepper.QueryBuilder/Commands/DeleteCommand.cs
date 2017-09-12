using Flepper.QueryBuilder.Base;

namespace Flepper.QueryBuilder
{
    internal class DeleteCommand : BaseQueryBuilder, IDeleteCommand
    {
        public DeleteCommand()
            => Command.Append("DELETE ");
    }
}
