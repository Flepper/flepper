using Flepper.Core.Base;

namespace Flepper.Core.QueryBuilder
{
    public class ComparisonOperators : BaseFlepperQueryBuilder, IComparisonOperators
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

        public void EqualTo(string value)
        {
            Command.AppendFormat("= '{0}' ", value);
        }

        public void EqualTo(int value)
        {
            Command.AppendFormat("= {0} ", value);
        }

        public void GreaterThan(int value)
        {
            Command.AppendFormat("> {0} ", value);
        }

        public void LessThan(int value)
        {
            Command.AppendFormat("< {0}", value);
        }

        public void GreaterThanOrEqualTo(int value)
        {
            Command.AppendFormat(">= {0} ", value);
        }

        public void LessThanOrEqualTo(int value)
        {
            Command.AppendFormat("<= {0} ", value);
        }

        public void NotEqualTo(int value)
        {
            Command.AppendFormat("<> {0} ", value);
        }

        public void NotEqualTo(string value)
        {
            Command.AppendFormat("<> '{0}' ", value);
        }
    }
}
