namespace Flepper.QueryBuilder.Base
{
    internal partial class BaseQueryBuilder : IWhereFilter
    {
        public IWhereFilter Where(string field)
        {
            Command.AppendFormat("WHERE [{0}] ", field);
            return this;
        }

        public IWhereFilter Where(string tableAlias, string field)
        {
            Command.AppendFormat("WHERE {0}.[{1}] ", tableAlias, field);
            return this;
        }
    }
}
