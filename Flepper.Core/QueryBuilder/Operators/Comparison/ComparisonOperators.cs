using Flepper.Core.Base;
using Flepper.Core.Utils.Extensions;

namespace Flepper.Core.QueryBuilder
{
    internal class ComparisonOperators : BaseQueryBuilder, IComparisonOperators
    {
        private static ComparisonOperators _instance;

        private ComparisonOperators()
        {
        }

        public static ComparisonOperators Create()
        {
            if (_instance is null) _instance = new ComparisonOperators();

            return _instance;
        }

        public void EqualTo(object value)
        {
            Command.AppendFormat("= {0} ", value.InsertQuotationMarksIfDateOrString());
        }

        public void GreaterThan(int value)
        {
            Command.AppendFormat("> {0} ", value);
        }

        public void GreaterThanOrEqualTo(int value)
        {
            Command.AppendFormat(">= {0} ", value);
        }

        public void LessThan(int value)
        {
            Command.AppendFormat("< {0} ", value);
        }

        public void LessThanOrEqualTo(int value)
        {
            Command.AppendFormat("<= {0} ", value);
        }

        public void NotEqualTo(object value)
        {
            Command.AppendFormat("<> {0} ", value.InsertQuotationMarksIfDateOrString());
        }
    }
}
