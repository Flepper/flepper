using System.Collections.Generic;
using System.Text;
using Flepper.QueryBuilder.Base;
using Flepper.QueryBuilder.Operators.Grouping.Interfaces;
using Flepper.QueryBuilder.Operators.Grouping.Interfaces;

namespace Flepper.QueryBuilder.Base
{
    internal partial class BaseQueryBuilder : IGrouping
    {
        /// <summary>
        /// Group select statement by column
        /// </summary>
        /// <param name="column">grouped column</param>
        /// <returns></returns>
        public IGrouping GroupBy(string column)
        {
            Command.AppendFormat("GROUP BY [{0}]", column);
            return this;
        }
    }
}
