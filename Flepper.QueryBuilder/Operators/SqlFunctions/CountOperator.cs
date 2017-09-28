using System;
using Flepper.QueryBuilder.Base;
using static System.String;
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
        /// <param name="alias">alias to column. All alias start with</param>
        /// <param name="tableAlias">used for internal process to set a table alias to column</param>
        public CountOperator(string column, string alias, string tableAlias = "") : base(column, alias, _countFunction, tableAlias)
        {

        }
    }
}
