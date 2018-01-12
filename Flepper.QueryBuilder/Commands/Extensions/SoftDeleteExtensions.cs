using System;
using System.Collections.Generic;
using System.Text;

namespace Flepper.QueryBuilder
{
    /// <summary>
    /// SoftDelete Extensions methods
    /// </summary>
    public static class SoftDeleteExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="softDeleteCommand"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public static IWhereFilter Where(this ISoftDeleteCommand softDeleteCommand, string column)
            => softDeleteCommand is IWhereFilter command ? command.Where(column) : null;
    }
}
