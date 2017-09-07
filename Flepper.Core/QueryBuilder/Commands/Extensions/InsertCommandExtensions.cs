using Flepper.Core.QueryBuilder.Commands.Interfaces;
using Flepper.Core.QueryBuilder.Operators.Values;

namespace Flepper.Core.QueryBuilder.Commands.Extensions
{
    public static class InsertCommandExtensions
    {
      public static void Values(this IInsertCommand command, params string[] values)
        {
            var valuesOperator = new ValuesOperator();
            valuesOperator.Values(values);
        }
    }
}
