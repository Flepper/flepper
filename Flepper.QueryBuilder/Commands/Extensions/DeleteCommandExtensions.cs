namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Delete command extensions
    /// </summary>
    public static class DeleteCommandExtensions
    {
        /// <summary>
        /// Add From command to query
        /// </summary>
        /// <param name="deleteCommand">Delete command instance</param>
        /// <param name="table">Table name</param>
        /// <returns></returns>
        public static IFromCommand From(this IDeleteCommand deleteCommand, string table)
            => deleteCommand is IFromCommand command ? command.FromCommand(table) : null;
    }
}
