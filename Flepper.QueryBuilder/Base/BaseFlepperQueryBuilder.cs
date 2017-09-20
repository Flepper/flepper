using System;
using System.Collections.Generic;
using System.Text;
using Flepper.QueryBuilder.Utils;

namespace Flepper.QueryBuilder.Base
{
    internal abstract class BaseQueryBuilder : IQueryCommand
    {
        protected readonly StringBuilder Command;
        protected readonly IDictionary<string, object> Parameters;

        protected BaseQueryBuilder()
        {
            Command = new StringBuilder();
            Parameters = new Dictionary<string, object>();
        }

        protected BaseQueryBuilder(StringBuilder command, IDictionary<string, object> parameters)
        {
            Command = command;
            Parameters = parameters;
        }

        public string Build()
            => Command.ToString();

        public QueryResult BuildWithParameters()
            => new QueryResult(Command.ToString(), ParameterObjectBuilder.CreateObjectWithValues(Parameters));

        public TEnd To<TEnd>()
            where TEnd : IQueryCommand
            => (TEnd)Activator.CreateInstance(typeof(TEnd), Command, Parameters);

        public TEnd To<TEnd>(Func<StringBuilder, IDictionary<string, object>, TEnd> creator)
            => creator(Command, Parameters);

        protected int AddParameters(params object[] values)
        {
            var parametersCount = Parameters.Count;
            for (var i = 0; i < values.Length; i++)
                Parameters.Add($"@p{parametersCount + i}", values[i]);
            return parametersCount;
        }
    }
}
