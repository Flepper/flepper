using System;

namespace Flepper.QueryBuilder
{
    public static class UpdateCommandExtensions
    {
        public static ISetOperator Set(this IUpdateCommand updateCommand, string column, string value)
            => updateCommand.To<SetOperator>().Set(column, value);

        public static ISetOperator Set(this IUpdateCommand updateCommand, string column, int value)
            => updateCommand.To<SetOperator>().Set(column, value);

        public static ISetOperator Set(this IUpdateCommand updateCommand, string column, DateTime value)
            => updateCommand.To<SetOperator>().Set(column, value);
    }
}
