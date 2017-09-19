using Flepper.QueryBuilder.Utils.Extensions;

namespace Flepper.QueryBuilder
{
    internal partial class QueryBuilder : ISelectCommand
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
