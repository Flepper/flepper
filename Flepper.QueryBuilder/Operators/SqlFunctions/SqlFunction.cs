namespace Flepper.QueryBuilder.Operators.SqlFunctions
{
    /// <summary>
    /// sql functions interface
    /// </summary>
    public abstract class SqlFunction
    {

        /// <summary>
        /// implicit operator to an implementation of SqlFunction
        /// </summary>
        /// <param name="column">column name</param>
        //public static implicit operator SqlFunction(string column)
        //{
        //    return SqlBaseFunction.CreateBaseFunction(column);
        //}

        /// <summary>
        /// implicit operator to string.
        /// </summary>
        /// <param name="function">an instance of SqlFunction</param>
        //public static implicit operator string(SqlFunction function)
        //{
        //    return SqlBaseFunction.ConverToString(function);
        //}
    }
}
