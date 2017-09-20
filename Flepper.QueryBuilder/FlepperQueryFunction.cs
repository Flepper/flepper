using Flepper.QueryBuilder.Operators.SqlFunctions;
using Flepper.QueryBuilder.Operators.SqlFunctions.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flepper.QueryBuilder
{
    /// <summary>
    /// 
    /// </summary>
    public static class FlepperQueryFunction
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="column"></param>
        /// <param name="alias"></param>
        /// <returns></returns>
        public static ISqlFunction Count(string column, string alias)
            => new CountOperator(column, alias);
    }
}
