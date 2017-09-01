using Flepper.Core.QueryBuilder.Commands.Interfaces;

namespace Flepper.Core.QueryBuilder.Commands.Extensions
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
