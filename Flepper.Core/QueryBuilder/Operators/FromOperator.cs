using Flepper.Core.Base;
using Flepper.Core.QueryBuilder.Operators.Interfaces;

namespace Flepper.Core.QueryBuilder.Operators
{
    public class FromOperator : BaseFlepperQueryBuilder, IFromOperator
    {
        public IFromOperator From(string schema, string table)
        {
            return this;
        }

        public IFromOperator From(string table)
        {
            Command.AppendFormat("FROM [{0}] ", table).AppendLine();
            return this;
        }
    }
}
