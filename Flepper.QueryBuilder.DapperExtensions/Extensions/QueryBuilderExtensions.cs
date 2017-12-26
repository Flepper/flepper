using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System;
using static Dapper.SqlMapper;

namespace Flepper.QueryBuilder.DapperExtensions
{
    public static class QueryBuilderExtensions
    {
        internal static FlepperDapperQuery AsFlepperDapperQuery(this IQueryCommand queryCommand)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
                return flepperDapperQuery;
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }
        public static int Execute(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().Execute(transaction, commandTimeout, commandType);
        }

        public static Task<int> ExecuteAsync(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().ExecuteAsync(transaction, commandTimeout, commandType);
        }

        public static IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(this IQueryCommand queryCommand, Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().Query(map, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public static IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TReturn>(this IQueryCommand queryCommand, Func<TFirst, TSecond, TThird, TFourth, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().Query(map, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public static IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TReturn>(this IQueryCommand queryCommand, Func<TFirst, TSecond, TThird, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().Query(map, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public static IEnumerable<dynamic> Query(this IQueryCommand queryCommand, IDbTransaction transaction = null,
            bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().Query(transaction, buffered, commandTimeout, commandType);
        }

        public static IEnumerable<TReturn> Query<TFirst, TSecond, TReturn>(this IQueryCommand queryCommand, Func<TFirst, TSecond, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().Query(map, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public static IEnumerable<TReturn> Query<TReturn>(this IQueryCommand queryCommand, Type[] types, Func<object[], TReturn> map, IDbTransaction transaction = null,
            bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().Query(types, map, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public static IEnumerable<T> Query<T>(this IQueryCommand queryCommand, IDbTransaction transaction = null, bool buffered = true,
            int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().Query<T>(transaction, buffered, commandTimeout, commandType);
        }

        public static IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(this IQueryCommand queryCommand, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().Query(map, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public static IEnumerable<object> Query(this IQueryCommand queryCommand, Type type, string sql, IDbTransaction transaction = null,
            bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().Query(type, transaction, buffered, commandTimeout, commandType);
        }

        public static Task<IEnumerable<dynamic>> QueryAsync(this IQueryCommand queryCommand, IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().QueryAsync(transaction, commandTimeout, commandType);
        }

        public static Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TReturn>(this IQueryCommand queryCommand, Func<TFirst, TSecond, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().QueryAsync(map, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public static Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TReturn>(this IQueryCommand queryCommand, Func<TFirst, TSecond, TThird, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().QueryAsync(map, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public static Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TReturn>(this IQueryCommand queryCommand, Func<TFirst, TSecond, TThird, TFourth, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().QueryAsync(map, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public static Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(this IQueryCommand queryCommand, Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().QueryAsync(map, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public static Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(this IQueryCommand queryCommand, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().QueryAsync(map, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public static Task<IEnumerable<TReturn>> QueryAsync<TReturn>(this IQueryCommand queryCommand, Type[] types, Func<object[], TReturn> map, IDbTransaction transaction = null,
            bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().QueryAsync(types, map, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public static Task<IEnumerable<object>> QueryAsync(this IQueryCommand queryCommand, Type type, IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().QueryAsync(type, transaction, commandTimeout, commandType);
        }

        public static Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(this IQueryCommand queryCommand, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().QueryAsync(map, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public static Task<IEnumerable<T>> QueryAsync<T>(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().QueryAsync<T>(transaction, commandTimeout, commandType);
        }

        public static dynamic QueryFirst(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().QueryFirst(transaction, commandTimeout, commandType);
        }

        public static object QueryFirst(this IQueryCommand queryCommand, Type type, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().QueryFirst(transaction, commandTimeout, commandType);
        }

        public static T QueryFirst<T>(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().QueryFirst<T>(transaction, commandTimeout, commandType);
        }

        public static Task<object> QueryFirstAsync(this IQueryCommand queryCommand, Type type, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().QueryFirstAsync(type, transaction, commandTimeout, commandType);
        }

        public static Task<T> QueryFirstAsync<T>(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().QueryFirstAsync<T>(transaction, commandTimeout, commandType);
        }

        public static T QueryFirstOrDefault<T>(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().QueryFirstOrDefault<T>(transaction, commandTimeout, commandType);
        }

        public static object QueryFirstOrDefault(this IQueryCommand queryCommand, Type type, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().QueryFirstOrDefault(type, transaction, commandTimeout, commandType);
        }

        public static dynamic QueryFirstOrDefault(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().QueryFirstOrDefault(transaction, commandTimeout, commandType);
        }

        public static Task<object> QueryFirstOrDefaultAsync(this IQueryCommand queryCommand, Type type, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().QueryFirstOrDefaultAsync(type, transaction, commandTimeout, commandType);
        }

        public static Task<T> QueryFirstOrDefaultAsync<T>(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().QueryFirstOrDefaultAsync<T>(transaction, commandTimeout, commandType);
        }

        public static GridReader QueryMultiple(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().QueryMultiple(transaction, commandTimeout, commandType);
        }

        public static Task<GridReader> QueryMultipleAsync(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().QueryMultipleAsync(transaction, commandTimeout, commandType);
        }

        public static dynamic QuerySingle(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().QuerySingle(transaction, commandTimeout, commandType);
        }

        public static object QuerySingle(this IQueryCommand queryCommand, Type type, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().QuerySingle(type, transaction, commandTimeout, commandType);
        }

        public static T QuerySingle<T>(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().QuerySingle<T>(transaction, commandTimeout, commandType);
        }

        public static Task<T> QuerySingleAsync<T>(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().QuerySingleAsync<T>(transaction, commandTimeout, commandType);
        }

        public static Task<object> QuerySingleAsync(this IQueryCommand queryCommand, Type type, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().QuerySingleAsync(type, transaction, commandTimeout, commandType);
        }

        public static T QuerySingleOrDefault<T>(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().QuerySingleOrDefault<T>(transaction, commandTimeout, commandType);
        }

        public static Task<dynamic> QuerySingleOrDefaultAsync<T>(this IQueryCommand queryCommand, Type type, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().QuerySingleOrDefaultAsync(type, transaction, commandTimeout, commandType);
        }

        public static Task<T> QuerySingleOrDefaultAsync<T>(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return queryCommand.AsFlepperDapperQuery().QuerySingleOrDefaultAsync<T>(transaction, commandTimeout, commandType);
        }
    }
}
