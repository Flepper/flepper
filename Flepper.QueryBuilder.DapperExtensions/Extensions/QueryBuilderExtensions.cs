using System.Data;
using System.Threading.Tasks;

namespace Flepper.QueryBuilder.DapperExtensions
{
    public static class QueryBuilderExtensions
    {
        public static int Execute(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
            => queryCommand.Execute(transaction, commandTimeout, commandType);

        public static Task<int> ExecuteAsync(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
            => queryCommand.ExecuteAsync(transaction, commandTimeout, commandType);
    }
}
