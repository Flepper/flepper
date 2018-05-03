using Flepper.QueryBuilder.Utils.Extensions;
using System;
using System.Linq;

namespace Flepper.QueryBuilder
{
    internal partial class QueryBuilder : IInsertCommand, IInsertIntoCommand, IInsertScopeIdentity
    {
        public IInsertIntoCommand Into(string table)
        {
            Command.AppendFormat("INSERT INTO [{0}] ", table);
            return this;
        }

        public IInsertIntoCommand Columns(params SqlColumn[] columns)
        {
            Command.AppendFormat("({0}) ", columns.Select(c => c.ToString()).JoinColumns());
            return this;
        }

	    public IInsertIntoCommand Columns(string[] columns)
	    {
		    var sqlColumns = columns.Select(c => new SqlColumn(c)).ToArray();
		    return Columns(sqlColumns);
	    }

	    public IValuesOperator WithScopeIdentity()
        {
            Command.AppendFormat("{0}", ";SELECT scope_identity();");
            return this;
        }

        public IInsertIntoIQueryCommand Columns(string[] columns, Func<IQueryCommand, IQueryCommand> query)
        {
            var sqlColumns = columns.Select(c => new SqlColumn(c)).ToArray();
            Columns(sqlColumns);
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
