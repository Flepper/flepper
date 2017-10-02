using System.Linq;

namespace Flepper.QueryBuilder
{
    internal partial class QueryBuilder : IValuesOperator
    {
        public IValuesOperator Values(params object[] values)
        {
            Command.AppendFormat("VALUES ({0})", string.Join(", ", Parameters.Skip(AddParameters(values)).Select(p => p.Key)));
            return this;
        }
    }
}
