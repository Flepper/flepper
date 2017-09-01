using Flepper.Core.Base;

namespace Flepper.Core.QueryBuilder
{
    public class FromCommand : BaseFlepperQueryBuilder, IFromCommand
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
