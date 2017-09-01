using Flepper.Core.QueryBuilder.Filters;
using Flepper.Core.QueryBuilder.Filters.Interfaces;
using Flepper.Core.QueryBuilder.Join.Operators.Comparison.Interfaces;

namespace Flepper.Core.QueryBuilder.Join.Operators.Comparison.Extensions
{
    public static class JoinComparisonOperatorsExtensions
    {
        public static IWhereFilter Where(this IJoinComparisonOperators joinComparisonOperators, string field)
        {
            var whereFilter = new WhereFilter();
            whereFilter.Where(field);
            return whereFilter;
        }

        public static IWhereFilter Where(this IJoinComparisonOperators joinComparisonOperators, string tableAlias, string field)
        {
            var whereFilter = new WhereFilter();
            whereFilter.Where(tableAlias, field);
            return whereFilter;
        }
    }
}
