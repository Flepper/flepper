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
        private const string TABLE_ALIAS = ".";

        private static readonly string[] AliasSplitter = { ALIAS, " as ", " As " };
        private static readonly string[] TableAliasSplitter = { TABLE_ALIAS };

        /// <summary>
        /// the column name or sql function.
        /// </summary>
        public string Column { get; protected set; }

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

            var containsAlias = ContainsAlias(column);
            var containsTableAlias = ContainsTableAlias(column);

            if (containsAlias && containsTableAlias)
            {
                var columnAsAlias = default(string);

                (TableAlias, columnAsAlias) = column.Split(TableAliasSplitter, StringSplitOptions.RemoveEmptyEntries);
                (Column, Alias) = columnAsAlias.Split(AliasSplitter, StringSplitOptions.RemoveEmptyEntries); ;
            }
            else if (containsAlias)
            {
                (Column, Alias) = column.Split(AliasSplitter, StringSplitOptions.RemoveEmptyEntries);
            }
            else if (containsTableAlias)
            {
                (TableAlias, Column) = column.Split(TableAliasSplitter, StringSplitOptions.RemoveEmptyEntries);
            }
            else
            {
                Column = $"{column}";
            }

            if(Column != "*")
            {
                if (!Column.StartsWith("[")) Column = $"[{Column}";
                if(!Column.EndsWith("]")) Column = $"{Column}]";
            }

            if(TableAlias != null)
            {
                if (!TableAlias.StartsWith("[")) TableAlias = $"[{TableAlias}";
                if (!TableAlias.EndsWith("]")) TableAlias = $"{TableAlias}]";
            }

            if (!IsNullOrWhiteSpace(Alias) && !Column.Contains(ALIAS)) Column = $"{Column} AS {Alias.Trim()}";
            if (!IsNullOrWhiteSpace(TableAlias) && !Column.Contains(TABLE_ALIAS)) Column = $"{TableAlias}.{Column}";
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool ContainsTableAlias(string source)
            => source.IndexOf(TABLE_ALIAS, StringComparison.OrdinalIgnoreCase) > 0;


        private static string GetTableAlias(string source)
            => source.Contains(TABLE_ALIAS) ? source?.Split('.')[0] : null;
    }
}
