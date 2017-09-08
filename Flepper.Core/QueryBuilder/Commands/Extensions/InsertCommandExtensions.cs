using Flepper.Core.QueryBuilder.Commands.Interfaces;
using Flepper.Core.QueryBuilder.Operators.Values;

namespace Flepper.Core.QueryBuilder
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
