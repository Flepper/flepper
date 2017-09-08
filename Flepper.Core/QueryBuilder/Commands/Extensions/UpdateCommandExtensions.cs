using System;
using Flepper.Core.QueryBuilder.Operators.Set;
using Flepper.Core.QueryBuilder.Operators.Set.Interfaces;

namespace Flepper.Core.QueryBuilder
{
    public static class UpdateCommandExtensions
    {
        public static ISetOperator Set(this IUpdateCommand updateCommand, string column, string value)
        {
            var setOperator = new SetOperator();
            setOperator.Set(column, value);
            return setOperator;
        }

        public static ISetOperator Set(this IUpdateCommand updateCommand, string column, int value)
        {
            var setOperator = new SetOperator();
            setOperator.Set(column, value);
            return setOperator;
        }

        public static ISetOperator Set(this IUpdateCommand updateCommand, string column, DateTime value)
        {
            var setOperator = new SetOperator();
            setOperator.Set(column, value);
            return setOperator;
        }
    }
}
