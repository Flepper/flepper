using Flepper.Core.Base;
using Flepper.Core.QueryBuilder.Operators.Set.Interfaces;

namespace Flepper.Core.QueryBuilder.Operators.Set
{
    public class SetOperator : BaseFlepperQueryBuilder, ISetOperator
    {
        public ISetOperator Set(string column, string value)
        {
            SetValue(column,value);

            return this;
        }

        public ISetOperator Set(string column, int value)
        {
            return this;
        }

        private static void SetValue(string column, string value)
        {
            Command.AppendFormat(Query.Contains("SET") 
                ? ",[{0}] = '{1}' " 
                : "SET [{0}] = '{1}' ", column, value);
        }
    }
}