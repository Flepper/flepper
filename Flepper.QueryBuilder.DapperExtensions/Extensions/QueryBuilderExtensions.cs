using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;

namespace Flepper.QueryBuilder.DapperExtensions
{
    public static class QueryBuilderExtensions
    {
        public static int Execute(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
            => queryCommand.Execute(transaction, commandTimeout, commandType);

        public static Task<int> ExecuteAsync(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
            => queryCommand.ExecuteAsync(transaction, commandTimeout, commandType);

        public static IEnumerable<T> Query<T>(this IQueryCommand cnn)
        {
            if (cnn is FlepperDapperQuery abs)
            {
                var queryResult = abs.BuildWithParameters();
                return abs.DbConnection.Query<T>(queryResult.Query, queryResult.Parameters);
            }
            return null;
        }

    }
}
