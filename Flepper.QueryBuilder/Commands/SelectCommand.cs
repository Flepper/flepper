using System;
using System.Linq;
using Flepper.QueryBuilder.Base;
using Flepper.QueryBuilder.Utils.Extensions;

namespace Flepper.QueryBuilder.Base
{
    internal partial class BaseQueryBuilder : ISelectCommand
    {
        public ISelectCommand SelectCommand()
        {
            Columns = new[] { (SqlColumn)"*" };
            Command.Append("SELECT * ");
            return this;
        }

        public ISelectCommand SelectCommand(params SqlColumn[] columns)
        {
            if (columns.Any(c => c == null)) throw new ArgumentNullException(nameof(columns), "All columns names should not be null");

            Columns = columns;
            Command.AppendFormat("SELECT {0}", columns.Select(c => c.ToString()).JoinColumns());
        }
    }
}
