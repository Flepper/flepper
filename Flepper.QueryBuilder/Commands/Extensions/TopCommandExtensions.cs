namespace Flepper.QueryBuilder
{
    public static class TopCommandExtensions
    {
        public static IFromCommand From(this ITopCommand topCommand, string schema, string table)
            => topCommand.To((s, p) => new FromCommand(s, p, schema, table));

        public static IFromCommand From(this ITopCommand topCommand, string table)
            => topCommand.To((s, p) => new FromCommand(s, p, table));
    }
}