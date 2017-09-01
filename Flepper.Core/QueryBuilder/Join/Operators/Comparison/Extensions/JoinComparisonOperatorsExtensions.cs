namespace Flepper.Core.QueryBuilder
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
