
using System.Text;
using Flepper.QueryBuilder.Base;

namespace Flepper.QueryBuilder
{
    internal class Join : BaseQueryBuilder, IJoin
    {
        public Join(StringBuilder command) : base(command)
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
