namespace Flepper.QueryBuilder
{
    public static class AliasOperatorExtensions
    {
        public static IWhereFilter Where(this IAliasOperator aliasOperator, string field)
            => aliasOperator.To<WhereFilter>().Where(field);

        public static IJoin InnerJoin(this IAliasOperator aliasOperator, string table)
            => aliasOperator.To<Join>().InnerJoin(table);

        public static IJoin LeftJoin(this IAliasOperator aliasOperator, string table)
            => aliasOperator.To<Join>().LeftJoin(table);

        public static IIOnOperator On(this IAliasOperator aliasOperator, string tableAlias, string column)
            => aliasOperator.To<OnOperator>().On(tableAlias, column);
    }
}
