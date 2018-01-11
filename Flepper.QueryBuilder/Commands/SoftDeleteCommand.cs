namespace Flepper.QueryBuilder
{
    internal partial class QueryBuilder : ISoftDeleteCommand
    {
        public ISoftDeleteCommand SoftDeleteCommand<T>(string table) where T : class
        {
            var className = typeof(T).Name;
            var softDeleteColumn = AdvancedSettings.GetColumn(className);

            Command.Append($"UPDATE [{table}] {SetValue(softDeleteColumn)} ");
            return this;
        }

        public ISoftDeleteCommand SoftDeleteCommand<T>() where T : class
        {
            var className = typeof(T).Name;
            var softDeleteColumn = AdvancedSettings.GetColumn(className);

            Command.Append($"UPDATE [{className}] {SetValue(softDeleteColumn)} ");
            return this;
        }

        private string SetValue(string column)
        {
            var paramCount = AddParameters(0);
            return $"SET [{column}] = @p{paramCount}";
        }
    }
}