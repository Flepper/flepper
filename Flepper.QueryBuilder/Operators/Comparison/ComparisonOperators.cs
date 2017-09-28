namespace Flepper.QueryBuilder
{
    internal partial class QueryBuilder : IComparisonOperators
    {
        public IComparisonOperators EqualTo<T>(T value)
        {
            if (value == null)
                Command.AppendFormat("IS NULL ");
            else
                Command.Append($"= @p{AddParameters(value)} ");

            return this;
        }

        public IComparisonOperators GreaterThan<T>(T value)
        {
            Command.Append($"> @p{AddParameters(value)} ");
            return this;
        }

        public IComparisonOperators GreaterThanOrEqualTo<T>(T value)
        {
            Command.Append($">= @p{AddParameters(value)} ");
            return this;
        }

        public IComparisonOperators LessThan<T>(T value)
        {
            Command.Append($"< @p{AddParameters(value)} ");
            return this;
        }

        public IComparisonOperators LessThanOrEqualTo<T>(T value)
        {
            Command.Append($"<= @p{AddParameters(value)} ");
            return this;
        }

        public IComparisonOperators NotEqualTo<T>(T value)
        {
            if (value == null)
                Command.AppendFormat("IS NOT NULL ");
            else
                Command.Append($"<> @p{AddParameters(value)} ");

            return this;
        }
    }
}
