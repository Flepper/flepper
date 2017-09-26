using System;
using System.Runtime.CompilerServices;
using Flepper.QueryBuilder.Utils.Extensions;
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
        public string Column { get; set; }

        /// <summary>
        /// the column alias
        /// </summary>
        public string Alias { get; }

        /// <summary>
        /// the table alias. Ex: [t1].[Column1] t1 the alias of the table
        /// </summary>
        public string TableAlias { get; }

        internal SqlColumn(string column)
        {
            if (IsNullOrWhiteSpace(column)) throw new ArgumentNullException($"{nameof(column)} cannot be null or empty");

            TableAlias = GetTableAlias(column);

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

        private static string GetTableAlias(string source)
        {
            if (source.Contains("."))
                return source.Split(new[] { '.' })[0];

            return null;
        }

        /// <summary>
        /// Shallow copy of the instance
        /// </summary>
        /// <returns></returns>
        public SqlColumn Clone()
        {
            return (SqlColumn)MemberwiseClone();
        }
    }
}
