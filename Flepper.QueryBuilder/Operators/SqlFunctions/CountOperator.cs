using System;
using static System.String;
using Flepper.QueryBuilder.Base;
namespace Flepper.QueryBuilder.Operators.SqlFunctions
{
    /// <summary>
    /// Count Operator class
    /// </summary>
    public sealed class CountOperator : FunctionOperator
    {
        private static string _countFunction = "COUNT";

        /// <summary>
        /// constructor to Count class
        /// </summary>
        /// <param name="column">column name</param>
        /// <param name="alias">alias to column. All alias start with func_</param>
        public CountOperator(string column, string alias) : base(column, alias, _countFunction)
        {

        }

        private CountOperator(string column) : base(column)
        {

        }

        /// <summary>
        /// implicit operator to CountOperator
        /// </summary>
        /// <param name="column">column name</param>
        public static implicit operator CountOperator(string column)
            => new CountOperator(column);

        /// <summary>
        /// Overwrite ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
            => Column;
    }
}
