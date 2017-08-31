using Flepper.Core.Base;
using Flepper.Core.QueryBuilder.Filters.Interfaces;

namespace Flepper.Core.QueryBuilder.Filters
{
    public class WhereFilter : BaseFlepperQueryBuilder, IWhereFilter
    {
        public void Where(string field)
        {
            Command.AppendFormat("WHERE [{0}] ", field);
        }
    }
}
