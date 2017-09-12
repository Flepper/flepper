using System.Text;
using Flepper.QueryBuilder.Base;

namespace Flepper.QueryBuilder
{
    internal class FromCommand : BaseQueryBuilder, IFromCommand
    {
        public FromCommand(StringBuilder command, string schema, string table)
            : base(command) 
            => Command.AppendFormat("FROM [{0}].[{1}] ", schema, table);

        public FromCommand(StringBuilder command, string table)
            : base(command) 
            => Command.AppendFormat("FROM [{0}] ", table);
    }
}
