using System;
using static System.String;
namespace Flepper.QueryBuilder.Operators.SqlFunctions
{
    ///<summary>
    /// Function class
    ///</summary>
    public class FunctionOperator : SqlColumn
    {
        internal FunctionOperator(string column, string alias, string function) : base(column)
        {
            if (IsNullOrWhiteSpace(column) || IsNullOrWhiteSpace(alias)) throw new ArgumentNullException($"{nameof(column)} and {nameof(alias)} cannot be null or empty");
            if (column.Contains("."))
                Column = $"{function}({column}) AS {alias}";
            else
                Column = $"{function}([{column}]) AS {alias}";
        }


        /// <summary>
        /// default constructor to suport implicit operators
        /// </summary>
        protected FunctionOperator(string column) : base(column)
        {

        }
    }
}