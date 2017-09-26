using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using static Dapper.SqlMapper;

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

        public IEnumerable<T> Query<T>(IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.Query<T>(queryResult.Query, queryResult.Parameters, transaction, buffered, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.Query(queryResult.Query, map, queryResult.Parameters, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public IEnumerable<object> Query(Type type, IDbTransaction transaction = null,
            bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.Query(type, queryResult.Query, queryResult.Parameters, transaction, buffered, commandTimeout, commandType);
        }

        public Task<IEnumerable<dynamic>> QueryAsync(IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.QueryAsync(queryResult.Query, queryResult.Parameters, transaction, commandTimeout, commandType);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TReturn>(Func<TFirst, TSecond, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.QueryAsync(queryResult.Query, map, queryResult.Parameters, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TReturn>(Func<TFirst, TSecond, TThird, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.QueryAsync(queryResult.Query, map, queryResult.Parameters, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TReturn>(Func<TFirst, TSecond, TThird, TFourth, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.QueryAsync(queryResult.Query, map, queryResult.Parameters, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.QueryAsync(queryResult.Query, map, queryResult.Parameters, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.QueryAsync(queryResult.Query, map, queryResult.Parameters, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TReturn>(Type[] types, Func<object[], TReturn> map, IDbTransaction transaction = null,
            bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.QueryAsync(queryResult.Query, types, map, queryResult.Parameters, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public Task<IEnumerable<object>> QueryAsync(Type type, IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.QueryAsync(type, queryResult.Query, queryResult.Parameters, transaction, commandTimeout, commandType);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.QueryAsync(queryResult.Query, map, queryResult.Parameters, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public Task<IEnumerable<T>> QueryAsync<T>(IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.QueryAsync<T>(queryResult.Query, queryResult.Parameters, transaction, commandTimeout, commandType);
        }

        public dynamic QueryFirst(IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.QueryFirst(queryResult.Query, queryResult.Parameters, transaction, commandTimeout, commandType);
        }

        public object QueryFirst(Type type, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.QueryFirst(type, queryResult.Query, queryResult.Parameters, transaction, commandTimeout, commandType);
        }

        public T QueryFirst<T>(IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.QueryFirst(queryResult.Query, queryResult.Parameters, transaction, commandTimeout, commandType);
        }

        public Task<object> QueryFirstAsync(Type type, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.QueryFirstAsync(type, queryResult.Query, queryResult.Parameters, transaction, commandTimeout, commandType);
        }

        public Task<T> QueryFirstAsync<T>(IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.QueryFirstAsync<T>(queryResult.Query, queryResult.Parameters, transaction, commandTimeout, commandType);
        }

        public T QueryFirstOrDefault<T>(IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.QueryFirstOrDefault<T>(queryResult.Query, queryResult.Parameters, transaction, commandTimeout, commandType);
        }

        public object QueryFirstOrDefault(Type type, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.QueryFirstOrDefault(type, queryResult.Query, queryResult.Parameters, transaction, commandTimeout, commandType);
        }

        public dynamic QueryFirstOrDefault(IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.QueryFirstOrDefault(queryResult.Query, queryResult.Parameters, transaction, commandTimeout, commandType);
        }

        public Task<object> QueryFirstOrDefaultAsync(Type type, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.QueryFirstOrDefaultAsync(type, queryResult.Query, queryResult.Parameters, transaction, commandTimeout, commandType);
        }

        public Task<T> QueryFirstOrDefaultAsync<T>(IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.QueryFirstOrDefaultAsync<T>(queryResult.Query, queryResult.Parameters, transaction, commandTimeout, commandType);
        }

        public GridReader QueryMultiple(IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.QueryMultiple(queryResult.Query, queryResult.Parameters, transaction, commandTimeout, commandType);
        }

        public Task<GridReader> QueryMultipleAsync(IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.QueryMultipleAsync(queryResult.Query, queryResult.Parameters, transaction, commandTimeout, commandType);
        }

        public dynamic QuerySingle(IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.QuerySingle(queryResult.Query, queryResult.Parameters, transaction, commandTimeout, commandType);
        }

        public object QuerySingle(Type type, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.QuerySingle(type, queryResult.Query, queryResult.Parameters, transaction, commandTimeout, commandType);
        }

        public T QuerySingle<T>(IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.QuerySingle<T>(queryResult.Query, queryResult.Parameters, transaction, commandTimeout, commandType);
        }

        public Task<T> QuerySingleAsync<T>(IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.QuerySingleAsync<T>(queryResult.Query, queryResult.Parameters, transaction, commandTimeout, commandType);
        }

        public Task<object> QuerySingleAsync(Type type, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.QuerySingleAsync(type, queryResult.Query, queryResult.Parameters, transaction, commandTimeout, commandType);
        }

        public T QuerySingleOrDefault<T>(IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.QuerySingleOrDefault<T>(queryResult.Query, queryResult.Parameters, transaction, commandTimeout, commandType);
        }

        public Task<dynamic> QuerySingleOrDefaultAsync(Type type, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.QuerySingleOrDefaultAsync(type, queryResult.Query, queryResult.Parameters, transaction, commandTimeout, commandType);
        }

        public Task<T> QuerySingleOrDefaultAsync<T>(IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            var queryResult = BuildWithParameters();
            return dbConnection.QuerySingleOrDefaultAsync<T>(queryResult.Query, queryResult.Parameters, transaction, commandTimeout, commandType);
        }
    }
}
