using System.Collections.Generic;
using System.Text;
using Flepper.QueryBuilder.Base;

namespace Flepper.QueryBuilder
{
    internal class ComparisonOperators : BaseQueryBuilder, IComparisonOperators
    {
        public ComparisonOperators(StringBuilder command, IDictionary<string, object> parameters, SqlColumn[] columns) : base(command, parameters, columns)
        {
        }

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
