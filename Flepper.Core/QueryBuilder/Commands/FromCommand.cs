using Flepper.Core.Base;
using Flepper.Core.QueryBuilder.Commands.Interfaces;

namespace Flepper.Core.QueryBuilder.Commands
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
