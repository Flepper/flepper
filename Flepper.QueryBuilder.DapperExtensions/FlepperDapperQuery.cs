using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;

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
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.Query(queryResult.Query, map, queryResult.Parameters, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.Query(queryResult.Query, map, queryResult.Parameters, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TReturn>(Func<TFirst, TSecond, TThird, TFourth, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.Query(queryResult.Query, map, queryResult.Parameters, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TReturn>(Func<TFirst, TSecond, TThird, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.Query(queryResult.Query, map, queryResult.Parameters, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public IEnumerable<dynamic> Query(IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.Query(queryResult.Query, queryResult.Parameters, transaction, buffered, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TFirst, TSecond, TReturn>(Func<TFirst, TSecond, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.Query(queryResult.Query, map, queryResult.Parameters, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TReturn>(Type[] types, Func<object[], TReturn> map, IDbTransaction transaction = null,
            bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.Query(queryResult.Query, types, map, queryResult.Parameters, transaction, buffered, splitOn, commandTimeout, commandType);
        }
    }
}
