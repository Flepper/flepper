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
        /// <param name="alias">alias to column. All alias start with func_</param>
        public MinOperator(string column, string alias) : base(column, alias, _minFunction)
        {

        }

        private MinOperator(string column) : base(column)
        {

        }
    }
}