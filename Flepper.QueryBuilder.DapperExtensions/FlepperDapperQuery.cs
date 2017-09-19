using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Flepper.QueryBuilder.DapperExtensions
{
    internal class FlepperDapperQuery : QueryBuilder
    {
        private readonly IDbConnection dbConnection;

        public FlepperDapperQuery(IDbConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public int Execute(IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.Execute(queryResult.Query, queryResult.Parameters, transaction, commandTimeout, commandType);
        }

        public Task<int> ExecuteAsync(IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.ExecuteAsync(queryResult.Query, queryResult.Parameters, transaction, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map,
            object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
            => dbConnection.Query(Build(), map, param, transaction, buffered, splitOn, commandTimeout, commandType);

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map,
            object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
            => dbConnection.Query(Build(), map, param, transaction, buffered, splitOn, commandTimeout, commandType);

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TReturn>(Func<TFirst, TSecond, TThird, TFourth, TReturn> map,
            object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
            => dbConnection.Query(Build(), map, param, transaction, buffered, splitOn, commandTimeout, commandType);
    }
}
