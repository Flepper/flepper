namespace Flepper.QueryBuilder.Base
{
    internal partial class BaseQueryBuilder : IFromCommand
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
