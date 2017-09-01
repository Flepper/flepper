using Flepper.Core.Base;

namespace Flepper.Core.QueryBuilder
{
    public class WhereFilter : BaseFlepperQueryBuilder, IWhereFilter
    {
        public void Where(string field)
        {
            Command.AppendFormat("WHERE [{0}] ", field);
        }

        public void Where(string tableAlias, string field)
        {
            Command.AppendFormat("WHERE {0}.[{1}] ", tableAlias, field);
        }
    }
}
