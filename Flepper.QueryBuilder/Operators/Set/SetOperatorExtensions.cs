namespace Flepper.QueryBuilder
{
    public static class SetOperatorExtensions
    {
        public static IWhereFilter Where(this ISetOperator fromCommand, string field)
            => fromCommand.To<WhereFilter>().Where(field);
    }
}
