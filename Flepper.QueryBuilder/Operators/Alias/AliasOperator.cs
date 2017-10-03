using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flepper.QueryBuilder
{
    internal partial class QueryBuilder : IAliasOperator
    {
        public IAliasOperator As(string alias)
        {
            // QueryColumns = QueryColumns.Select(c => c.TableAlias != null ? c : new SqlColumn($"[{alias}].{c}")).ToArray();

            var command = Command.ToString();

            Command.Clear();
            Command.Append($"SELECT {string.Join(",", QueryColumns.Select(c => c.ToString()))} FROM {command.Split(new[] { "FROM " }, StringSplitOptions.RemoveEmptyEntries)[1].Trim()} ");

            Command.AppendFormat("AS {0} ", alias);

            return this;
        }
    }
}