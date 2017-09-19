using Flepper.QueryBuilder.Base;
using Flepper.QueryBuilder.Utils.Extensions;

namespace Flepper.QueryBuilder.Base
{
    internal partial class BaseQueryBuilder : ISelectCommand
    {
        public ISelectCommand SelectCommand()
        {
            Command.Append("SELECT * ");
            return this;
        }

        public ISelectCommand SelectCommand(params string[] columns)
        {
            Command.AppendFormat("SELECT {0}", columns.JoinColumns());
            return this;
        }
    }
}
