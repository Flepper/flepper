using System.Collections.Generic;
using System.Text;
using Flepper.QueryBuilder.Base;

namespace Flepper.QueryBuilder
{
    internal class FromCommand : BaseQueryBuilder, IFromCommand
    {
        public FromCommand(StringBuilder command, IDictionary<string, object> parameters, string schema, string table) 
            : base(command, parameters)
            => Command.AppendFormat("FROM [{0}].[{1}] ", schema, table);

        public FromCommand(StringBuilder command, IDictionary<string, object> parameters, string table) 
            : base(command, parameters)
            => Command.AppendFormat("FROM [{0}] ", table);
    }
}
