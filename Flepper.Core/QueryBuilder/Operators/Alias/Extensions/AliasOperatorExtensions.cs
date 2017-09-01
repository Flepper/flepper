
namespace Flepper.Core.QueryBuilder
{
    public static class AliasOperatorExtensions
    {
        public static IWhereFilter Where(this IAliasOperator aliasOperator, string field)
        {
            var whereFilter = new WhereFilter();
            whereFilter.Where(field);
            return whereFilter;
        }

        public static IJoin InnerJoin(this IAliasOperator aliasOperator, string table)
        {
            var join = new Join();
            join.Inner(table);
            return join;
        }

        public static IIOnOperator On(this IAliasOperator aliasOperator, string tableAlias, string column)
        {
            var onOperator = new OnOperator();
            onOperator.On(tableAlias, column);
            return onOperator;
        }
    }
}
