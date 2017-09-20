using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using System;

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
    }
}
