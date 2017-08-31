using Flepper.Core.Base;
using Flepper.Core.QueryBuilder.Join.Interfaces;

namespace Flepper.Core.QueryBuilder.Join
{
    public class Join : BaseFlepperQueryBuilder, IJoin
    {
        public void Inner(string table)
        {
            Command.AppendFormat("INNER JOIN [{0}] ", table);
        }

        public void Left(string table)
        {
            Command.AppendFormat("LEFT JOIN [{0}] ", table);
        }
    }
}
