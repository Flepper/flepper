using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System;
<<<<<<< HEAD
using static Dapper.SqlMapper;
=======
>>>>>>> 8442d37b6296be4f9b44dbf91193a2ff2d60c70a

namespace Flepper.QueryBuilder.DapperExtensions
{
    public static class QueryBuilderExtensions
    {
        public static int Execute(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.Execute(transaction, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static Task<int> ExecuteAsync(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.ExecuteAsync(transaction, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(this IQueryCommand queryCommand, Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.Query(map, transaction, buffered, splitOn, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TReturn>(this IQueryCommand queryCommand, Func<TFirst, TSecond, TThird, TFourth, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.Query(map, transaction, buffered, splitOn, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TReturn>(this IQueryCommand queryCommand, Func<TFirst, TSecond, TThird, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.Query(map, transaction, buffered, splitOn, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static IEnumerable<dynamic> Query(this IQueryCommand queryCommand, IDbTransaction transaction = null,
            bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.Query(transaction, buffered, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static IEnumerable<TReturn> Query<TFirst, TSecond, TReturn>(this IQueryCommand queryCommand, Func<TFirst, TSecond, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.Query(map, transaction, buffered, splitOn, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static IEnumerable<TReturn> Query<TReturn>(this IQueryCommand queryCommand, Type[] types, Func<object[], TReturn> map, IDbTransaction transaction = null,
            bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.Query(types, map, transaction, buffered, splitOn, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static IEnumerable<T> Query<T>(this IQueryCommand queryCommand, IDbTransaction transaction = null, bool buffered = true,
            int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.Query<T>(transaction, buffered, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(this IQueryCommand queryCommand, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.Query(map, transaction, buffered, splitOn, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static IEnumerable<object> Query(this IQueryCommand queryCommand, Type type, string sql, IDbTransaction transaction = null,
            bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.Query(type, transaction, buffered, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static Task<IEnumerable<dynamic>> QueryAsync(this IQueryCommand queryCommand, IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.QueryAsync(transaction, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TReturn>(this IQueryCommand queryCommand, Func<TFirst, TSecond, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.QueryAsync(map, transaction, buffered, splitOn, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TReturn>(this IQueryCommand queryCommand, Func<TFirst, TSecond, TThird, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.QueryAsync(map, transaction, buffered, splitOn, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TReturn>(this IQueryCommand queryCommand, Func<TFirst, TSecond, TThird, TFourth, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.QueryAsync(map, transaction, buffered, splitOn, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(this IQueryCommand queryCommand, Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.QueryAsync(map, transaction, buffered, splitOn, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(this IQueryCommand queryCommand, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.QueryAsync(map, transaction, buffered, splitOn, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static Task<IEnumerable<TReturn>> QueryAsync<TReturn>(this IQueryCommand queryCommand, Type[] types, Func<object[], TReturn> map, IDbTransaction transaction = null,
            bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.QueryAsync(types, map, transaction, buffered, splitOn, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static Task<IEnumerable<object>> QueryAsync(this IQueryCommand queryCommand, Type type, IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.QueryAsync(type, transaction, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(this IQueryCommand queryCommand, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.QueryAsync(map, transaction, buffered, splitOn, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static Task<IEnumerable<T>> QueryAsync<T>(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.QueryAsync<T>(transaction, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static dynamic QueryFirst(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.QueryFirst(transaction, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static object QueryFirst(this IQueryCommand queryCommand, Type type, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.QueryFirst(transaction, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static T QueryFirst<T>(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.QueryFirst<T>(transaction, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static Task<object> QueryFirstAsync(this IQueryCommand queryCommand, Type type, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.QueryFirstAsync(type, transaction, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static Task<T> QueryFirstAsync<T>(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.QueryFirstAsync<T>(transaction, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static T QueryFirstOrDefault<T>(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.QueryFirstOrDefault<T>(transaction, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static object QueryFirstOrDefault(this IQueryCommand queryCommand, Type type, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.QueryFirstOrDefault(type, transaction, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static dynamic QueryFirstOrDefault(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.QueryFirstOrDefault(transaction, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static Task<object> QueryFirstOrDefaultAsync(this IQueryCommand queryCommand, Type type, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.QueryFirstOrDefaultAsync(type, transaction, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static Task<T> QueryFirstOrDefaultAsync<T>(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.QueryFirstOrDefaultAsync<T>(transaction, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static GridReader QueryMultiple(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.QueryMultiple(transaction, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static Task<GridReader> QueryMultipleAsync(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.QueryMultipleAsync(transaction, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static dynamic QuerySingle(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.QuerySingle(transaction, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static object QuerySingle(this IQueryCommand queryCommand, Type type, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.QuerySingle(type, transaction, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static T QuerySingle<T>(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.QuerySingle<T>(transaction, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static Task<T> QuerySingleAsync<T>(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.QuerySingleAsync<T>(transaction, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static Task<object> QuerySingleAsync(this IQueryCommand queryCommand, Type type, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.QuerySingleAsync(type, transaction, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static T QuerySingleOrDefault<T>(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.QuerySingleOrDefault<T>(transaction, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static Task<dynamic> QuerySingleOrDefaultAsync<T>(this IQueryCommand queryCommand, Type type, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.QuerySingleOrDefaultAsync(type, transaction, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }

        public static Task<T> QuerySingleOrDefaultAsync<T>(this IQueryCommand queryCommand, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            if (queryCommand is FlepperDapperQuery flepperDapperQuery)
            {
                return flepperDapperQuery.QuerySingleOrDefaultAsync<T>(transaction, commandTimeout, commandType);
            }
            throw new NotSupportedException("Only instances of FlepperDapperQuery can execute this method.");
        }
    }
}
