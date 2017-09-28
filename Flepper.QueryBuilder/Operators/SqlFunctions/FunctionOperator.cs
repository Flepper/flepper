using System;
using Flepper.QueryBuilder.Base;
using static System.String;
namespace Flepper.QueryBuilder.Operators.SqlFunctions
{
    ///<summary>
    /// Function class
    ///</summary>
    public class FunctionOperator : SqlColumn
    {
        internal FunctionOperator(string column, string alias, string function,string tableAlias = "") : base(column,alias)
        {
            if (IsNullOrWhiteSpace(column) || IsNullOrWhiteSpace(alias)) throw new ArgumentNullException($"{nameof(column)} and {nameof(alias)} cannot be null or empty");

            Column = IsNullOrWhiteSpace(tableAlias) ? $"{function}([{column}]) AS {alias}" :  $"{function}([{tableAlias}].[{column}]) AS {alias}";
        }


        /// <summary>
        /// default constructor to suport implicit operators
        /// </summary>
        protected FunctionOperator(string column) : base(column)
        {

        }
    }
}