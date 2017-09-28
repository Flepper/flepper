namespace Flepper.QueryBuilder.Base
{
    internal partial class BaseQueryBuilder : IJoin
    {
        public IJoin InnerJoin(string table)
        {
            Command.AppendFormat("INNER JOIN [{0}] ", table);
            return this;
        }

        public IJoin LeftJoin(string table)
        {
            Command.AppendFormat("LEFT JOIN [{0}] ", table);
            return this;
        }
    }
}
