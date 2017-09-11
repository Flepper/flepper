
namespace Flepper.QueryBuilder
{
    public static class SetOperatorExtensions
    {
        public static IWhereFilter Where(this ISetOperator fromCommand, string field)
        {
            var whereFilter = new WhereFilter();
            whereFilter.Where(field);
            return whereFilter;
        }
    }
}
