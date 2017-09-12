using Flepper.QueryBuilder.Base;
using Flepper.QueryBuilder.Utils.Extensions;

namespace Flepper.QueryBuilder
{
    internal class SelectCommand : BaseQueryBuilder, ISelectCommand
    {
        public SelectCommand() 
            => Command.Append("SELECT * ");

        public SelectCommand(params string[] columns) 
            => Command.AppendFormat("SELECT {0}", columns.JoinColumns());
    }
}
