using Flepper.QueryBuilder.Base;

namespace Flepper.QueryBuilder
{
    internal class UpdateCommand : BaseQueryBuilder, IUpdateCommand
    {
        public UpdateCommand(string table) 
            => Command.AppendFormat("UPDATE [{0}] ", table);

        public UpdateCommand(string schema, string table) 
            => Command.AppendFormat("UPDATE [{0}].[{1}] ", schema, table);
    }
}