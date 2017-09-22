using System;
using System.Linq;
using Flepper.QueryBuilder.Base;
using Flepper.QueryBuilder.Operators.SqlFunctions;
using Flepper.QueryBuilder.Utils.Extensions;

namespace Flepper.QueryBuilder
{
    internal class SelectCommand : BaseQueryBuilder, ISelectCommand
    {
        public SelectCommand() 
            => Command.Append("SELECT * ");

       public SelectCommand(params SqlColumn[] columns)
        {
            if (columns.Any(c => c == null))
                throw new ArgumentNullException(nameof(columns), "All columns names should not be null");
            Command.AppendFormat("SELECT {0}", columns.Select(c => c.ToString()).JoinColumns());
        }
    }
}
