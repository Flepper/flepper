namespace Flepper.QueryBuilder
{
    internal partial class QueryBuilder : IJoin
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
