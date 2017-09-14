using System.Collections.Generic;
using System.Text;
using Flepper.QueryBuilder.Base;

namespace Flepper.QueryBuilder
{
    internal class Join : BaseQueryBuilder, IJoin
    {
        public Join(StringBuilder command, IDictionary<string, object> parameters) : base(command, parameters)
        {
        }

        public IJoin InnerJoin(string table)
        {
            Command.AppendFormat("INNER JOIN [{0}] ", table);
            return this;
        }

        public IJoin LeftJoin(string table)
        {
            Command.AppendFormat("LEFT JOIN [{0}] ", table);
            return this;
        }
    }
}
