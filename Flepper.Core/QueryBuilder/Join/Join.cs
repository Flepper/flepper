using Flepper.Core.Base;

namespace Flepper.Core.QueryBuilder
{
    internal class Join : BaseQueryBuilder, IJoin
    {
        public void InnerJoin(string table)
        {
            Command.AppendFormat("INNER JOIN [{0}] ", table);
        }

        public void LeftJoin(string table)
        {
            Command.AppendFormat("LEFT JOIN [{0}] ", table);
        }
    }
}
