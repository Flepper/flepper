namespace Flepper.QueryBuilder.Operators.SqlFunctions
{
    /// <summary>
    /// MIN Operator class
    /// </summary>
    public sealed class AsFromOperator : FunctionOperator
    {

        /// <summary>
        /// constructor to AsFromOperator class
        /// </summary>
        /// <param name="column">column name</param>
        /// <param name="alias">alias to column. All alias start with func_</param>
        public AsFromOperator(string alias, string column) : base(column, alias, string.Empty)
            => Column = column == "*" ? $"[{alias}].{column}" : $"[{alias}].[{column}]";

        /// <summary>
        /// constructor to AsFromOperator class
        /// </summary>
        /// <param name="alias">alias to column. All alias start with func_</param>
        /// <param name="column">column name</param>
        public AsFromOperator(string alias, SqlColumn column) : base(nameof(AsFromOperator))
            => Column = $"[{alias}].{column}";

    }
}