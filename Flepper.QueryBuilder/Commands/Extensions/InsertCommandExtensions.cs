namespace Flepper.QueryBuilder
{
    public static class InsertCommandExtensions
    {
        public static IValuesOperator Values(this IInsertIntoCommand command, params object[] values)
            => command.To<ValuesOperator>().Values(values);
    }
}
