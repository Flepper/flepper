
using System.Text;
using Flepper.QueryBuilder.Base;

namespace Flepper.QueryBuilder
{
    internal class AliasOperator : BaseQueryBuilder, IAliasOperator
    {
        public AliasOperator(StringBuilder command) : base(command)
        {
        }

        public IAliasOperator As(string alias)
        {
            Command.AppendFormat("{0} ", alias);
            return this;
        }
    }
}