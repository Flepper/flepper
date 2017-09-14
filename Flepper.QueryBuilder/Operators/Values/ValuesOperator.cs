using System.Collections.Generic;
using System.Linq;
using System.Text;
using Flepper.QueryBuilder.Base;

namespace Flepper.QueryBuilder
{
    internal class ValuesOperator : BaseQueryBuilder, IValuesOperator
    {
        public ValuesOperator(StringBuilder command, IDictionary<string, object> parameters) : base(command, parameters)
        {
        }

        public IValuesOperator Values(params object[] values)
        {
            var parametersCount = AddParameters(values);

            Command.AppendFormat("VALUES ({0})", string.Join(", ", Parameters.Skip(parametersCount).Select(p => p.Key)));
            return this;
        }
    }
}
