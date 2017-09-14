using System.Collections.Generic;
using System.Text;
using Flepper.QueryBuilder.Base;

namespace Flepper.QueryBuilder
{
    internal class AliasOperator : BaseQueryBuilder, IAliasOperator
    {
        public AliasOperator(StringBuilder command, IDictionary<string, object> parameters) : base(command, parameters)
        {
        }

        public IAliasOperator As(string alias)
        {
            Command.AppendFormat("{0} ", alias);
            return this;
        }
    }
}