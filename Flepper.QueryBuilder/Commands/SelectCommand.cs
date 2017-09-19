using System;
using System.Linq.Expressions;
using Flepper.QueryBuilder.Utils;
using Flepper.QueryBuilder.Utils.Extensions;

namespace Flepper.QueryBuilder
{
    internal partial class QueryBuilder : ISelectCommand
    {
        public ISelectCommand SelectCommand()
        {
            Command.Append("SELECT * ");
            return this;
        }

        public ISelectCommand SelectCommand(params string[] columns)
        {
            Command.AppendFormat("SELECT {0}", columns.JoinColumns());
            return this;
        }

        public ISelectCommand SelectCommand<T>()
            where T : class
            => SelectCommand(Cache.GetTypeProperties<T>());

        public ISelectCommand SelectCommand<T>(Expression<Func<T, object>> expression)
            where T : class
            => SelectCommand(Cache.GetTypeProperties<T>());
    }
}
