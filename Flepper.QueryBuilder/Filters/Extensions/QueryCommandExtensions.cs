using System;
using System.Text;
using Flepper.QueryBuilder.Base;

namespace Flepper.QueryBuilder
{
    public static class QueryCommandExtensions
    {
        public static TEnd To<TEnd>(this IQueryCommand queryCommand)
        {
            if (queryCommand is BaseQueryBuilder query)
                return (TEnd)Activator.CreateInstance(typeof(TEnd), query.Command);
            throw new NotSupportedException();
        }

        public static TEnd To<TEnd>(this IQueryCommand queryCommand, Func<StringBuilder, TEnd> creator)
        {
            if (queryCommand is BaseQueryBuilder query)
                return creator(query.Command);
            throw new NotSupportedException();
        }
    }
}