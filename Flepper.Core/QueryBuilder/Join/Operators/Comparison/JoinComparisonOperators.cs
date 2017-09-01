using Flepper.Core.Base;
using Flepper.Core.QueryBuilder.Join.Operators.Comparison.Interfaces;

namespace Flepper.Core.QueryBuilder.Join.Operators.Comparison
{
    public class JoinComparisonOperators : BaseFlepperQueryBuilder, IJoinComparisonOperators
    {
        private static IJoinComparisonOperators _joinComparisonOperators;

        private JoinComparisonOperators()
        {
        }

        public static IJoinComparisonOperators Create()
        {
            if (_joinComparisonOperators is null) _joinComparisonOperators = new JoinComparisonOperators();

            return _joinComparisonOperators;
        }

        public void Equal(string tableAlias, string column)
        {
            Command.AppendFormat("= {0}.[{1}] ", tableAlias, column);
        }

        public void NotEqual(string tableAlias, string column)
        {
            Command.AppendFormat("<> {0}.[{1}] ", tableAlias, column);
        }
    }
}
