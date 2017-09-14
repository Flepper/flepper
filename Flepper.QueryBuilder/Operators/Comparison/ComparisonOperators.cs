using System.Collections.Generic;
using System.Text;
using Flepper.QueryBuilder.Base;

namespace Flepper.QueryBuilder
{
    internal class ComparisonOperators : BaseQueryBuilder, IComparisonOperators
    {
        public ComparisonOperators(StringBuilder command, IDictionary<string, object> parameters) : base(command, parameters)
        {
        }

        public IComparisonOperators EqualTo(object value)
        {
            if (value == null)
                Command.AppendFormat("IS NULL ");
            else
            {
                var parameter = AddParameters(value);
                Command.Append($"= @p{parameter} ");
            }

            return this;
        }

        public IComparisonOperators GreaterThan(int value)
        {
            var parameter = AddParameters(value);
            Command.Append($"> @p{parameter} ");
            return this;
        }

        public IComparisonOperators GreaterThanOrEqualTo(int value)
        {
            var parameter = AddParameters(value);
            Command.Append($">= @p{parameter} ");
            return this;
        }

        public IComparisonOperators LessThan(int value)
        {
            var parameter = AddParameters(value);
            Command.Append($"< @p{parameter} ");
            return this;
        }

        public IComparisonOperators LessThanOrEqualTo(int value)
        {
            var parameter = AddParameters(value);
            Command.Append($"<= @p{parameter} ");
            return this;
        }

        public IComparisonOperators NotEqualTo(object value)
        {
            if (value == null)
                Command.AppendFormat("IS NOT NULL ");
            else
            {
                var parameter = AddParameters(value);
                Command.Append($"<> @p{parameter} ");
            }

            return this;
        }
    }
}
