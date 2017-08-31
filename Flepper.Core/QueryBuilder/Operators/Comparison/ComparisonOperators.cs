using Flepper.Core.Base;
using Flepper.Core.QueryBuilder.Operators.Comparison.Interfaces;

namespace Flepper.Core.QueryBuilder.Operators.Comparison
{
    public class ComparisonOperators : BaseFlepperQueryBuilder, IComparisonOperators
    {
        private static ComparisonOperators _instance;

        private ComparisonOperators()
        {
        }

        public static ComparisonOperators Create()
        {
            if(_instance is null) _instance = new ComparisonOperators();

            return _instance;
        }

        public void Equal(string value)
        {
            Command.AppendFormat("= '{0}' ", value);
        }

        public void Equal(int value)
        {
            Command.AppendFormat("= {0} ", value);
        }

        public void Equal(object value)
        {
            Command.AppendFormat("= [{0}] ", value);
        }

        public void NotEqual(object value)
        {
            Command.AppendFormat("<> [{0}] ", value);
        }
    }
}
