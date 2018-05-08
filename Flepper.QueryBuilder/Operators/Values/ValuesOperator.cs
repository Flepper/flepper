using System;
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

        public IValuesOperator Values(Func<IQueryCommand, IQueryCommand> query)
        {            
            QueryBuilder querySelect = new QueryBuilder();
            querySelect = (QueryBuilder)query.Invoke(querySelect);
            Command.Append(querySelect.Command);
            foreach (var parameter in querySelect?.Parameters)
            {
                Parameters.Add(parameter.Key, parameter.Value);
            }
            return this;
        }
    }
}
