using System.Collections.Generic;
using System.Text;
using Flepper.QueryBuilder.Utils;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Flepper.QueryBuilder.DapperExtensions")]
namespace Flepper.QueryBuilder
{
    internal partial class QueryBuilder : IQueryCommand
    {
        protected SqlColumn[] Columns;
        protected readonly StringBuilder Command;
        protected readonly IDictionary<string, object> Parameters;

        internal QueryBuilder()
        {
            Command = new StringBuilder();
            Parameters = new Dictionary<string, object>();
        }

        internal QueryBuilder(StringBuilder command, IDictionary<string, object> parameters, SqlColumn[] columns)
        {
            Command = command;
            Parameters = parameters;
            Columns = columns;
        }

        public string Build()
            => Command.ToString();

        public QueryResult BuildWithParameters()
            => new QueryResult(Command.ToString(), ParameterObjectBuilder.CreateObjectWithValues(Parameters));

        protected int AddParameters(params object[] values)
        {
            var parametersCount = Parameters.Count;
            for (var i = 0; i < values.Length; i++)
                Parameters.Add($"@p{parametersCount + i}", values[i]);
            return parametersCount;
        }
    }
}
