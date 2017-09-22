using Flepper.QueryBuilder.Utils.Extensions;
using System;
using System.Runtime.CompilerServices;
using static System.String;
namespace Flepper.QueryBuilder.Base
{
    /// <summary>
    /// Base function class used to improve implicit conversion
    /// </summary>
    public class SqlColumn
    {
        private const string ALIAS = " AS ";
        private static readonly string[] AliasSplitter = { ALIAS, " as ", " As " };

        /// <summary>
        /// the column name or sql function.
        /// </summary>
        protected string Column { get; set; }
        
        /// <summary>
        /// the column alias
        /// </summary>
        protected string Alias { get; }

        internal SqlColumn(string column)
        {
            if (IsNullOrWhiteSpace(column)) throw new ArgumentNullException($"{nameof(column)} cannot be null or empty");
            if (ContainsAlias(column))
                (Column, Alias) = column.Split(AliasSplitter, StringSplitOptions.RemoveEmptyEntries);
            else
                Column = $"[{column}]";

            if (!IsNullOrWhiteSpace(Alias)) Column = $"[{Column}] AS {Alias}";
        }

        /// <summary>
        /// implicit operator to convert sqlColumn instance to string
        /// </summary>
        /// <param name="column"></param>
        public static implicit operator string(SqlColumn column)
            => column.Column;

        /// <summary>
        /// implicit operator to convert string to sqlColumn instance
        /// </summary>
        /// <param name="column"></param>
        public static implicit operator SqlColumn(string column)
            => new SqlColumn(column);

        /// <summary>
        /// ovveride ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString() => Column;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool ContainsAlias(string source)
            => source.IndexOf(ALIAS, StringComparison.OrdinalIgnoreCase) > 0;
    }
}
