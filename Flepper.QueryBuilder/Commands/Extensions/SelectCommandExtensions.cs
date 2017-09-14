namespace Flepper.QueryBuilder
{
    public static class SelectCommandExtensions
    {
        public static IFromCommand From(this ISelectCommand selectCommand, string schema, string table) 
            => selectCommand.To(s => new FromCommand(s, schema, table));

        public static IFromCommand From(this ISelectCommand selectCommand, string table) 
            => selectCommand.To(s => new FromCommand(s, table));

        public static ITopCommand Top(this ISelectCommand selectCommand, int size = 1)
            => selectCommand.To(s => new TopCommand(s, size));



    }
}
