using System;
using Flepper.Core.Base;
using Flepper.Core.QueryBuilder.Operators.Set.Interfaces;

namespace Flepper.Core.QueryBuilder.Operators.Set
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