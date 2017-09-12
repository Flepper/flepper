namespace Flepper.QueryBuilder
{
    public static class FromCommandExtensions
    {
        public static IWhereFilter Where(this IFromCommand fromCommand, string field)
            => fromCommand.To<WhereFilter>().Where(field);

        public static IJoin InnerJoin(this IFromCommand fromCommand, string table)
            => fromCommand.To<Join>().InnerJoin(table);

        public static IJoin LeftJoin(this IFromCommand fromCommand, string table)
            => fromCommand.To<Join>().LeftJoin(table);

        public static IAliasOperator As(this IFromCommand fromCommand, string alias)
            => fromCommand.To<AliasOperator>().As(alias);
    }
}
