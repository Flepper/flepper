using System.Data;

namespace Flepper.QueryBuilder.DapperExtensions
{
    public static class DbConnectionExtensions
    {
        public static IQueryCommand FlepperQuery(this IDbConnection dbConnection) => new FlepperDapperQuery(dbConnection);
    }
}
