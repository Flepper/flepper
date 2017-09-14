namespace Flepper.QueryBuilder
{
    public struct QueryResult
    {
        public QueryResult(string query, object parameters)
        {
            Query = query;
            Parameters = parameters;
        }

        public string Query { get; }
        public object Parameters { get; }

        public static implicit operator string(QueryResult queryResult)
            => queryResult.Query;
    }
}