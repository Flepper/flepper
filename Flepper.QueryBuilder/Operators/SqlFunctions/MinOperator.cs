using System;
using Flepper.QueryBuilder.Base;
using static System.String;

namespace Flepper.QueryBuilder.Operators.SqlFunctions
{
    /// <summary>
    /// MIN Operator class
    /// </summary>
    public sealed class MinOperator : FunctionOperator
    {
        private static string _minFunction = "MIN";

        /// <summary>
        /// constructor to Min class
        /// </summary>
        /// <param name="column">column name</param>
        /// <param name="alias">alias to column.</param>
        /// <param name="tableAlias">used for internal process to set a table alias to column</param>
        public MinOperator(string column, string alias,string tableAlias = "") : base(column, alias, _minFunction,tableAlias)
        {

        }
    }
}