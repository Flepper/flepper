using System.Text;
using Flepper.QueryBuilder.Base;
using Flepper.QueryBuilder.Utils.Extensions;

namespace Flepper.QueryBuilder
{
    internal class ComparisonOperators : BaseQueryBuilder, IComparisonOperators
    {
        public ComparisonOperators(StringBuilder command) : base(command)
        {
        }

        public IComparisonOperators EqualTo(object value)
        {
            if(value == null)
            {
                Command.AppendFormat("IS NULL ");
                return this;
            }
            Command.AppendFormat("= {0} ", value.InsertQuotationMarksIfDateOrString());
            return this;
        }

        public IComparisonOperators GreaterThan(int value)
        {
            Command.AppendFormat("> {0} ", value);
            return this;
        }

        public IComparisonOperators GreaterThanOrEqualTo(int value)
        {
            Command.AppendFormat(">= {0} ", value);
            return this;
        }

        public IComparisonOperators LessThan(int value)
        {
            Command.AppendFormat("< {0} ", value);
            return this;
        }

        public IComparisonOperators LessThanOrEqualTo(int value)
        {
            Command.AppendFormat("<= {0} ", value);
            return this;
        }

        public IComparisonOperators NotEqualTo(object value)
        {
            if (value == null)
            {
                Command.AppendFormat("IS NOT NULL ");
                return this;
            }
            Command.AppendFormat("<> {0} ", value.InsertQuotationMarksIfDateOrString());
            return this;
        }
    }
}
