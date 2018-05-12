using Flepper.QueryBuilder.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public IComparisonOperators EqualNull()
        {
            Command.AppendFormat("IS NULL ");
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

        public IComparisonOperators Contains<T>(T value)
        {
            Command.Append($"LIKE @p{AddParameters($"%{value}%")} ");
            return this;
        }

        public IComparisonOperators StartsWith<T>(T value)
        {
            Command.Append($"LIKE @p{AddParameters($"%{value}")} ");
            return this;
        }

        public IComparisonOperators EndsWith<T>(T value)
        {
            Command.Append($"LIKE @p{AddParameters($"{value}%")} ");
            return this;
        }

        public IComparisonOperators Between<TFrom, TTo>(TFrom from, TTo to)
        {
            Command.Append($"BETWEEN @p{AddParameters(from)} AND @p{AddParameters(to)} ");
            return this;
        }

        private IComparisonOperators InOrNotIn(string o, params object[] values)
        {
            Command.Append($"{o}(");
            for (int i = 0; i < values.Length; i++)
            {
                if (i > 0) Command.Append(",");
                Command.Append($"@p{AddParameters(values.GetValue(i))}");
            }
            Command.Append(") ");
            return this;
        }

        public IComparisonOperators In(params object[] values)
        {
            return InOrNotIn("IN", values);
        }

        public IComparisonOperators NotIn(params object[] values)
        {
            return InOrNotIn("NOT IN", values);            
        }

        private IComparisonOperators InOrNotInQueryCommand(string o, Func<IQueryCommand, IQueryCommand> query)
        {
            IDictionary<string, string> parametersReplace = new Dictionary<string, string>();
            Command.Append($"{o}(");
            QueryBuilder querySelect = query.AsQueryBuilder();
            foreach (var parameter in querySelect?.Parameters)
            {
                int p = AddParameters(parameter.Value);
                if (Parameters.ContainsKey(parameter.Key))
                {
                    parametersReplace.Add(parameter.Key, $"@p{p}");
                }
            }
            Command.Append(querySelect.Command.Replace(parametersReplace));
            Command.Append(") ");
            parametersReplace = null;
            return this;
        }

        public IComparisonOperators In(Func<IQueryCommand, IQueryCommand> query)
        {
            return InOrNotInQueryCommand("IN", query);
        }

        public IComparisonOperators NotIn(Func<IQueryCommand, IQueryCommand> query)
        {
            return InOrNotInQueryCommand("NOT IN", query);
        }
    }
}
