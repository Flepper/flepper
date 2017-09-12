namespace Flepper.QueryBuilder
{
    public static class DeleteCommandExtensions
    {
        public static IFromCommand From(this IDeleteCommand deleteCommand, string table)
            => deleteCommand.To(s => new FromCommand(s, table));
    }
}
