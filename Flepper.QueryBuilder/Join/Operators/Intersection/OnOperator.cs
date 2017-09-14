using System.Collections.Generic;
using System.Text;
using Flepper.QueryBuilder.Base;

namespace Flepper.QueryBuilder
{
    internal class OnOperator : BaseQueryBuilder, IIOnOperator
    {
        public OnOperator(StringBuilder command, IDictionary<string, object> parameters) : base(command, parameters)
        {
        }

        public IIOnOperator On(string tableAlias, string column)
        {
            Command.AppendFormat("ON {0}.[{1}] ", tableAlias, column);
            return this;
        }
    }
}
