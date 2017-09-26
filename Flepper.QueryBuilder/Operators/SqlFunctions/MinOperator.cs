using System;
using Flepper.QueryBuilder.Base;
using static System.String;


/// <summary>
    /// MIN Operator class
    /// </summary>
public sealed class MinOperator : SqlColumn
{
    
     /// <summary>
        /// constructor to Min class
        /// </summary>
        /// <param name="column">column name</param>
        /// <param name="alias">alias to column. All alias start with func_</param>
        public MinOperator(string column, string alias) : base(column)
        {
            if (IsNullOrWhiteSpace(column) || IsNullOrWhiteSpace(alias)) throw new ArgumentNullException($"{nameof(column)} and {nameof(alias)} cannot be null or empty");

            Column = $"MIN([{column}]) AS {alias}";
        }

    private MinOperator(string column) : base(column)
    {
        
    }

    /// <summary>
        /// implicit operator to MinOperator
        /// </summary>
        /// <param name="column">column name</param>
        public static implicit operator MinOperator(string column)
            => new MinOperator(column);

        /// <summary>
        /// Overwrite ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
            => Column;
}