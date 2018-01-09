namespace Flepper.QueryBuilder.Operators.SqlFunctions
{
    /// <summary>
    /// MaxOperator class
    /// </summary>
    public class MaxOperator : FunctionOperator
    {
        private static string  _maxFunction = "MAX";
        /// <summary>
        /// constructor MaxOperator class
        /// </summary>
        /// <param name="column">column name to put into Max function</param>
        /// <param name="alias">alias to column</param>
        public MaxOperator(string column, string alias) : base(column, alias,_maxFunction)
        {
        }
    }
}
