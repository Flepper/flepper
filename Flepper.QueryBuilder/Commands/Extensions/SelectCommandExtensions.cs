namespace Flepper.QueryBuilder
{
    public static class SelectCommandExtensions
    {
        public static IFromCommand From(this ISelectCommand selectCommand, string schema, string table)
        {
            var fromOperator = new FromCommand();
            fromOperator.From(schema, table);
            return fromOperator;
        }

        public static IFromCommand From(this ISelectCommand selectCommand, string table)
        {
            var fromOperator = new FromCommand();
            fromOperator.From(table);
            return fromOperator;
        }
    }
}
