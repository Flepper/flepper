namespace Flepper.QueryBuilder
{
    public static class InsertCommandExtensions
    {
        public static IValuesOperator Values(this IInsertCommand command, params object[] values) 
            => command.To<ValuesOperator>().Values(values);
    }
}
