using System;

namespace Flepper.QueryBuilder.Operators.SqlFunctions
{
    /// <summary>
    /// Base function class used to improve implicit conversion
    /// </summary>
    public class SqlBaseFunction : SqlFunction
    {
       /// <summary>
       /// the column name or sql function.
       /// </summary>
        protected string Column { get;  set; }


       
        internal SqlBaseFunction(string column)
        {
            if (string.IsNullOrEmpty(column)) throw new ArgumentNullException($"{nameof(column)} cannot be null or empty");
            Column = $"[{column}]";
        }

        internal SqlBaseFunction()
        {

        }

        /// <summary>
        /// A factory method that it is using by SqlFunction abstract class
        /// in order to convert SqlFunction to string with implicit operators
        /// </summary>
        /// <param name="column name"></param>
        internal static SqlBaseFunction CreateBaseFunction(string column)
        => new SqlBaseFunction(column);

        /// <summary>
        /// A factory method that it is using by SqlFunction abstract class
        /// in order to convert string to SqlFunction with implicit operators
        /// </summary>
        /// <param name="function"></param>
        internal static string ConverToString(SqlFunction function)
       => ((SqlBaseFunction)function).Column;

        /// <summary>
        /// Implicit convertion SqlBaseFunction to string
        /// </summary>
        /// <param name="baseFunction">An instance of SqlBaseFunction class</param>
        public static implicit operator string(SqlBaseFunction baseFunction)
            => baseFunction.Column;

        /// <summary>
        /// Implicit convertion string to SqlBaseFunction
        /// </summary>
        /// <param name="column">a column name</param>
        public static implicit operator SqlBaseFunction(string column)
            => new SqlBaseFunction(column);

        /// <summary>
        /// ovveride ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString() => Column;
    }
}
