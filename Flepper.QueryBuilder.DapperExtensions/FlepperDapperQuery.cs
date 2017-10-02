using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;

namespace Flepper.QueryBuilder.DapperExtensions
{
    internal class FlepperDapperQuery : QueryBuilder
    {
        public IDbConnection DbConnection { get; }

        public FlepperDapperQuery(IDbConnection dbConnection)
        {
            DbConnection = dbConnection;
        }

        public int Execute(IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return DbConnection.Execute(queryResult.Query, queryResult.Parameters, transaction, commandTimeout, commandType);
        }

        public Task<int> ExecuteAsync(IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return DbConnection.ExecuteAsync(queryResult.Query, queryResult.Parameters, transaction, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map,
            object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
            => DbConnection.Query(Build(), map, param, transaction, buffered, splitOn, commandTimeout, commandType);

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map,
            object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
            => DbConnection.Query(Build(), map, param, transaction, buffered, splitOn, commandTimeout, commandType);

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TReturn>(Func<TFirst, TSecond, TThird, TFourth, TReturn> map,
            object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
            => DbConnection.Query(Build(), map, param, transaction, buffered, splitOn, commandTimeout, commandType);
    }
}
