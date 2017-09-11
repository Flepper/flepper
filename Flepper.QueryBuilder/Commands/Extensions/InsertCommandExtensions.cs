namespace Flepper.QueryBuilder
{
    public static class InsertCommandExtensions
    {
      public static void Values(this IInsertCommand command, params object[] values)
        {
            var valuesOperator = new ValuesOperator();
            valuesOperator.Values(values);
        }
    }
}
