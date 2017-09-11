using Flepper.QueryBuilder.Base;
using System;

namespace Flepper.QueryBuilder
{
    internal class SetOperator : BaseQueryBuilder, ISetOperator
    {
        public ISetOperator Set(string column, string value)
        {
            SetValue(column, $"'{value}'");

            return this;
        }

        public ISetOperator Set(string column, int value)
        {
            SetValue(column, value);
            return this;
        }

        public ISetOperator Set(string column, DateTime value)
        {
            SetValue(column, $"'{value}'");
            return this;
        }

        private static void SetValue(string column, object value)
        {
            Command.AppendFormat(Query.Contains("SET")
                ? ",[{0}] = {1} "
                : "SET [{0}] = {1} ", column, value);
        }
    }
}