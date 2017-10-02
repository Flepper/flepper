using System;
using Flepper.QueryBuilder.Base;
using static System.String;

namespace Flepper.QueryBuilder.Operators.SqlFunctions
{ /// <summary>
  /// MIN Operator class
  /// </summary>
    public sealed class MaxOperator : FunctionOperator
    {
        private static string _minFunction = "MAX";

        /// <summary>
        /// constructor to Max class
        /// </summary>
        /// <param name="column">column name</param>
        /// <param name="alias">alias to column</param>
        /// <param name="tableAlias">used for internal process to set a table alias to column</param>
        public MaxOperator(string column, string alias, string tableAlias = "") : base(column, alias, _minFunction, tableAlias)
        {

        }
    }
}