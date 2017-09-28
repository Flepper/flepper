namespace Flepper.QueryBuilder.Base
{
    internal partial class BaseQueryBuilder : IJoinComparisonOperators
    {
        public IJoinComparisonOperators Equal(string tableAlias, string column)
        {
            Command.AppendFormat("= {0}.[{1}] ", tableAlias, column);
            return this;
        }

        public IJoinComparisonOperators NotEqual(string tableAlias, string column)
        {
            Command.AppendFormat("<> {0}.[{1}] ", tableAlias, column);
            return this;
        }
    }
}
