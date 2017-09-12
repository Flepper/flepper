
using System.Text;

namespace Flepper.QueryBuilder.Base
{
    internal abstract class BaseQueryBuilder
    {
        internal readonly StringBuilder Command;

        protected BaseQueryBuilder()
            => Command = new StringBuilder();

        protected BaseQueryBuilder(StringBuilder command)
            => Command = command;

        public string Build()
            => Command.ToString();
    }
}
