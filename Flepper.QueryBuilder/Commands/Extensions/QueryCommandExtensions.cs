using System;
namespace Flepper.QueryBuilder
{
    internal static class QueryCommandExtensions
    {        
        internal static QueryBuilder AsQueryBuilder(this Func<IQueryCommand, IQueryCommand> query)
        {                 
            return (QueryBuilder)query?.Invoke(new QueryBuilder());
        }
    }
}
