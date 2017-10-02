namespace Flepper.QueryBuilder
{
    internal partial class QueryBuilder : IAliasOperator
    {
        public IAliasOperator As(string alias)
        {
            Columns = Columns.Select(c => c.TableAlias != null ? c : new SqlColumn($"[{alias}].{c}")).ToArray();

            var command = Command.ToString();

            Command.Clear();
            Command.Append($"SELECT {string.Join(",", Columns.Select(c => c.ToString()))} FROM {command.Split(new[] { "FROM " }, StringSplitOptions.RemoveEmptyEntries)[1].Trim()} ");

            Command.AppendFormat("{0} ", alias);

            return this;
        }
    }
}