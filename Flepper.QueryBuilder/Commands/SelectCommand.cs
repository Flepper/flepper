using System;
using System.Linq.Expressions;
using Flepper.QueryBuilder.Utils;
using Flepper.QueryBuilder.Utils.Extensions;
using System.Linq;

namespace Flepper.QueryBuilder
{
    internal partial class QueryBuilder : ISelectCommand
    {
        public ISelectCommand SelectCommand()
        {
            QueryColumns = new[] { (SqlColumn)"*" };
            Command.Append("SELECT * ");
            return this;
        }

        public ISelectCommand SelectCommand(params SqlColumn[] columns)
        {
            if (columns.Any(c => c == null)) throw new ArgumentNullException(nameof(columns), "All columns names should not be null");

            QueryColumns = columns;
            Command.AppendFormat("SELECT {0}", columns.Select(c => c.ToString()).JoinColumns());
            return this;
        }

        public ISelectCommand SelectCommand<T>()
            where T : class
            => SelectCommand(Cache.GetTypeProperties<T>());

        public ISelectCommand SelectCommand<T>(Expression<Func<T, object>> expression)
            where T : class
            => SelectCommand(Cache.GetPropertiesFromExpression(expression));
    }
}
