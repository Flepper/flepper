namespace Flepper.QueryBuilder
{
    public static class SelectCommandExtensions
    {
        public static IFromCommand From(this ISelectCommand selectCommand, string schema, string table)
            => selectCommand.To((s, p) => new FromCommand(s, p, schema, table));

        public static IFromCommand From(this ISelectCommand selectCommand, string table)
            => selectCommand.To((s, p) => new FromCommand(s, p, table));
    }
}
