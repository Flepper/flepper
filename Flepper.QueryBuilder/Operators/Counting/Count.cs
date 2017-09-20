using System;
namespace Flepper.QueryBuilder.Operators.Counting
{
    /// <summary>
    /// 
    /// </summary>
    public class Count
    {
        /// <summary>
        /// column using in the count function;
        /// </summary>
        private string Column;

        /// <summary>
        /// alias to column
        /// </summary>
        private string Alias;

        /// <summary>
        /// constructor to Count class
        /// </summary>
        /// <param name="column"></param>
        /// <param name="alias"></param>
        public Count(string column, string alias)
        {
            if (string.IsNullOrEmpty(column) || string.IsNullOrEmpty(alias)) throw new ArgumentNullException($"{nameof(column)} and {nameof(alias)} cannot be null or empty");
            Column = column;
            Alias = alias;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string(Count count)
        {
            return $"COUNT([{count.Column}]) AS {count.Alias} ";
        }

    }
}
