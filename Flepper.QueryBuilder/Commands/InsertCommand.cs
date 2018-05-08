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
    }
}
