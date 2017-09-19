
namespace Flepper.QueryBuilder.Base
{
    internal partial class BaseQueryBuilder : ISetOperator
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