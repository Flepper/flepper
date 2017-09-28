using System.Collections.Generic;
using System.Text;

namespace Flepper.QueryBuilder
{
    internal partial class QueryBuilder : ISetOperator
    {
        public ISetOperator Set<T>(string column, T value)
        {
            var parametersCount = AddParameters(value);

            SetValue(column, $"@p{parametersCount}");
            return this;
        }

        private void SetValue(string column, object value)
        {
            Command.AppendFormat(Command.ToString().Contains("SET")
                ? ",[{0}] = {1} "
                : "SET [{0}] = {1} ", column, value);
        }
    }
}