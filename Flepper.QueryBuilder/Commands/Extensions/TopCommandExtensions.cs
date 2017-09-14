namespace Flepper.QueryBuilder
{
    public static class TopCommandExtensions
    {
        public static IFromCommand From(this ITopCommand topCommand, string schema, string table)
            => topCommand.To(s => new FromCommand(s, schema, table));

        public static IFromCommand From(this ITopCommand topCommand, string table)
            => topCommand.To(s => new FromCommand(s, table));
    }
}