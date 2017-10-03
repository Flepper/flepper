namespace Flepper.QueryBuilder
{
    internal partial class QueryBuilder : IWhereFilter
    {
        public IWhereFilter Where(string field)
        {
            Command.AppendFormat("WHERE [{0}] ", field);
            return this;
        }

        public IWhereFilter Where(string tableAlias, string field)
        {
            Command.AppendFormat("WHERE [{0}].[{1}] ", tableAlias, field);
            return this;
        }
    }
}
