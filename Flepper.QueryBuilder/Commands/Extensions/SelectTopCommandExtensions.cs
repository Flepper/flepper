namespace Flepper.QueryBuilder
{
    public static class SelectTopCommandExtensions
    {
        public static IFromCommand From(this ISelectTopCommand selectCommand, string schema, string table)
            => selectCommand.To(s => new FromCommand(s, schema, table));

        public static IFromCommand From(this ISelectTopCommand selectCommand, string table)
            => selectCommand.To(s => new FromCommand(s, table));
    }
}