using System;
using System.Collections.Generic;
using System.Text;
using Flepper.QueryBuilder.Utils;

namespace Flepper.QueryBuilder.Base
{
    internal partial class BaseQueryBuilder : IQueryCommand
    {
        protected SqlColumn[] Columns;
        protected readonly StringBuilder Command;
        protected readonly IDictionary<string, object> Parameters;

        internal BaseQueryBuilder()
        {
            Command = new StringBuilder();
            Parameters = new Dictionary<string, object>();
        }

        internal BaseQueryBuilder(StringBuilder command, IDictionary<string, object> parameters, SqlColumn[] columns)
        {
            Command = command;
            Parameters = parameters;
            Columns = columns;
        }

        public string Build()
            => Command.ToString();

        public QueryResult BuildWithParameters()
            => new QueryResult(Command.ToString(), ParameterObjectBuilder.CreateObjectWithValues(Parameters));

        public TEnd To<TEnd>()
            where TEnd : IQueryCommand
            => (TEnd)Activator.CreateInstance(typeof(TEnd), Command, Parameters, Columns);

        public TEnd To<TEnd>(Func<StringBuilder, IDictionary<string, object>, SqlColumn[], TEnd> creator)
            => creator(Command, Parameters, Columns);

        protected int AddParameters(params object[] values)
        {
            var parametersCount = Parameters.Count;
            for (var i = 0; i < values.Length; i++)
                Parameters.Add($"@p{parametersCount + i}", values[i]);
            return parametersCount;
        }
    }
}
