using System;
using static System.String;
namespace Flepper.QueryBuilder.Operators.SqlFunctions
{
    /// <summary>
    /// Count Operator class
    /// </summary>
    public sealed class CountOperator : SqlBaseFunction
    {

        /// <summary>
        /// constructor to Count class
        /// </summary>
        /// <param name="column">column name</param>
        /// <param name="alias">alias to column. All alias start with func_</param>
        public CountOperator(string column, string alias)
        {
            if (IsNullOrWhiteSpace(column) || IsNullOrWhiteSpace(alias)) throw new ArgumentNullException($"{nameof(column)} and {nameof(alias)} cannot be null or empty");

            Column = $"COUNT([{column}]) AS func_{alias} ";
        }

        private CountOperator(string column):base(column)
        {

        }
        
        /// <summary>
        /// implicit operator to string
        /// </summary>
        /// <param name="count">Count operator instance</param>
        public static implicit operator string(CountOperator count)
            => count.Column;

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
         => this.Column;
    }
}
