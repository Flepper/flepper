namespace Flepper.QueryBuilder
{
    internal partial class QueryBuilder : IUpdateCommand
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