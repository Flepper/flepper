namespace Flepper.QueryBuilder.Base
{
    internal partial class BaseQueryBuilder : IComparisonOperators
    {
        public IComparisonOperators EqualTo(object value)
        {
            if (value == null)
                Command.AppendFormat("IS NULL ");
            else
                Command.Append($"= @p{AddParameters(value)} ");

            return this;
        }

        public IComparisonOperators GreaterThan(int value)
        {
            Command.Append($"> @p{AddParameters(value)} ");
            return this;
        }

        public IComparisonOperators GreaterThanOrEqualTo(int value)
        {
            Command.Append($">= @p{AddParameters(value)} ");
            return this;
        }

        public IComparisonOperators LessThan(int value)
        {
            Command.Append($"< @p{AddParameters(value)} ");
            return this;
        }

        public IComparisonOperators LessThanOrEqualTo(int value)
        {
            Command.Append($"<= @p{AddParameters(value)} ");
            return this;
        }

        public IComparisonOperators NotEqualTo(object value)
        {
            if (value == null)
                Command.AppendFormat("IS NOT NULL ");
            else
                Command.Append($"<> @p{AddParameters(value)} ");

            return this;
        }
    }
}
