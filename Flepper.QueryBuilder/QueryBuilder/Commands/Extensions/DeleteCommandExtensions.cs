namespace Flepper.QueryBuilder
{
    public static class DeleteCommandExtensions
    {
        public static IFromCommand From(this IDeleteCommand deleteCommand, string table)
        {
            var fromCommand = new FromCommand();
            fromCommand.From(table);
            return fromCommand;
        }
    }
}
