using Flepper.QueryBuilder;
using Flepper.QueryBuilder.Base;
using Flepper.QueryBuilder.Utils.Extensions;

namespace Flepper.QueryBuilder
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
