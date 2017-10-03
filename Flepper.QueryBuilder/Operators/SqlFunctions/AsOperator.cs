namespace Flepper.QueryBuilder.Operators.SqlFunctions
{
    /// <summary>
    /// Count Operator class
    /// </summary>
    public sealed class AsOperator : FunctionOperator
    {

        /// <summary>
        /// constructor to Count class
        /// </summary>
        /// <param name="column">column name</param>
        /// <param name="alias">alias to column. All alias start with func_</param>
        public AsOperator(string column, string alias) : base(column, alias, string.Empty) 
            => Column = column.Contains(".") ? $"{column} AS {alias}" : $"[{column}] AS {alias}";
    }
}
