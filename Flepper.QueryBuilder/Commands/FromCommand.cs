namespace Flepper.QueryBuilder
{
    internal partial class QueryBuilder : IFromCommand
    {
        public IFromCommand FromCommand(string schema, string table)
        {
            Command.AppendFormat("FROM [{0}].[{1}] ", schema, table);
            return this;
        }

        public IFromCommand FromCommand(string table)
        {
            Command.AppendFormat("FROM [{0}] ", table);
            return this;
        }
    }
}
