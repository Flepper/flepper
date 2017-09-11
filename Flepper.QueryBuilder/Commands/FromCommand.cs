using Flepper.QueryBuilder.Base;

namespace Flepper.QueryBuilder
{
    internal class FromCommand : BaseQueryBuilder, IFromCommand
    {
        public IFromCommand From(string schema, string table)
        {
            Command.AppendFormat("FROM [{0}].[{1}] ", schema, table);

            return this;
        }

        public IFromCommand From(string table)
        {
            Command.AppendFormat("FROM [{0}] ", table);

            return this;
        }
    }
}
