using System;
using System.Text;
using Flepper.QueryBuilder.Base;

namespace Flepper.QueryBuilder
{
    internal class SetOperator : BaseQueryBuilder, ISetOperator
    {
        public SetOperator(StringBuilder command) : base(command)
        {
        }

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

        private void SetValue(string column, object value)
        {
            Command.AppendFormat(Command.ToString().Contains("SET")
                ? ",[{0}] = {1} "
                : "SET [{0}] = {1} ", column, value);
        }
    }
}