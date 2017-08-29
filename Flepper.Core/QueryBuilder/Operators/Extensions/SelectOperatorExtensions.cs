using Flepper.Core.QueryBuilder.Operators.Interfaces;

namespace Flepper.Core.QueryBuilder.Operators.Extensions
{
    public static class SelectOperatorExtensions
    {
        public static IFromOperator From(this ISelectOperator selectOperator, string schema, string table)
        {
            var fromOperator = new FromOperator();
            fromOperator.From(schema, table);
            return fromOperator;
        }

        public static IFromOperator From(this ISelectOperator selectOperator, string table)
        {
            var fromOperator = new FromOperator();
            fromOperator.From(table);
            return fromOperator;
        }
    }
}
