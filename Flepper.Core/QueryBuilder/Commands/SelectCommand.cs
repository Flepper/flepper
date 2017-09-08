using Flepper.Core.Base;
using Flepper.Core.Utils.Extensions;

namespace Flepper.Core.QueryBuilder
{
    internal class SelectCommand : BaseQueryBuilder, ISelectCommand
    {
        public ISelectCommand Select()
        {
            BeforeExecute();

            Command.Append("SELECT * ");
            return this;
        }

        public ISelectCommand Select(params string[] columns)
        {
            BeforeExecute();

            Command.AppendFormat("SELECT {0}", columns.JoinColumns());

            return this;
        }
    }
}
