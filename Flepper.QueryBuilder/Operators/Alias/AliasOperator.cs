using Flepper.QueryBuilder.Base;
using System.Collections.Generic;
using System.Text;

namespace Flepper.QueryBuilder
{
    internal class AliasOperator : BaseQueryBuilder, IAliasOperator
    {
        public AliasOperator(StringBuilder command, IDictionary<string, object> parameters, SqlColumn[] columns) : base(command, parameters, columns)
        {
        }

        public IAliasOperator As(string alias)
        {
            var command = new StringBuilder(Command.ToString());

            for (int i = 0; i < Columns.Length; i++)
            {
                var c = Columns[i];

                if (c.TableAlias == null)
                {
                    var columnWithAlias = $"[{alias}].{c}";
                    Columns[i] = new SqlColumn(columnWithAlias);

                    command = command.Replace(c, columnWithAlias);
                }
            }

            Command.Clear();
            Command.Append(command.ToString());

            Command.AppendFormat("{0} ", alias);

            return this;
        }
    }
}