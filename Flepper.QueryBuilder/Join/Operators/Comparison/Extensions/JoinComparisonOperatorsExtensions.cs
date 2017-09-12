namespace Flepper.QueryBuilder
{
    public static class JoinComparisonOperatorsExtensions
    {
        public static IWhereFilter Where(this IJoinComparisonOperators joinComparisonOperators, string field)
            => joinComparisonOperators.To<WhereFilter>().Where(field);

        public static IWhereFilter Where(this IJoinComparisonOperators joinComparisonOperators, string tableAlias, string field)
            => joinComparisonOperators.To<WhereFilter>().Where(tableAlias, field);
    }
}
