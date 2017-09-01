
namespace Flepper.Core.QueryBuilder
{
    public static class FromCommandExtensions
    {
        public static IWhereFilter Where(this IFromCommand fromCommand, string field)
        {
            var whereFilter = new WhereFilter();
            whereFilter.Where(field);
            return whereFilter;
        }

        public static IJoin InnerJoin(this IFromCommand fromCommand, string table)
        {
            var join = new Join();
            join.Inner(table);
            return join;
        }

        public static IAliasOperator As(this IFromCommand fromCommand, string alias)
        {
            var aliasOperator = new AliasOperator();

            aliasOperator.As(alias);

            return aliasOperator;
        }
    }
}
