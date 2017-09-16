using Flepper.QueryBuilder.Base;
using Flepper.QueryBuilder.Utils.Extensions;
using System.Collections.Generic;
using System.Text;

namespace Flepper.QueryBuilder
{
    internal class Sort : BaseQueryBuilder, ISort
    {
        public Sort(StringBuilder command, IDictionary<string, object> parameters) : base(command, parameters)
        {
        }

        public ISort OrderBy(params string[] columns)
        {
            Command.AppendFormat("ORDER BY {0}", columns.JoinColumns());
            return this;
        }

        public ISort OrderByDesc(params string[] columns)
        {
            Command.AppendFormat("ORDER BY {0} DESC", columns.JoinColumns().Trim());
            return this;
        }
    }
}
