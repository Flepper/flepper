namespace Flepper.QueryBuilder
{
    public static class SelectCommandExtensions
    {
        public static IFromCommand From(this ISelectCommand selectCommand, string schema, string table) 
            => selectCommand.To(s => new FromCommand(s, schema, table));

        public static IFromCommand From(this ISelectCommand selectCommand, string table) 
            => selectCommand.To(s => new FromCommand(s, table));
    }
}
