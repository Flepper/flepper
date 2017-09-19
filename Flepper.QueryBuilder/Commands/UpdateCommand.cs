namespace Flepper.QueryBuilder.Base
{
    internal partial class BaseQueryBuilder : IUpdateCommand
    {
        public IUpdateCommand UpdateCommand(string table)
        {
            Command.AppendFormat("UPDATE [{0}] ", table);
            return this;
        }

        public IUpdateCommand UpdateCommand(string schema, string table)
        {
            Command.AppendFormat("UPDATE [{0}].[{1}] ", schema, table);
            return this;
        }
    }
}