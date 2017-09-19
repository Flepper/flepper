
using Flepper.QueryBuilder.Utils.Extensions;

namespace Flepper.QueryBuilder
{
    internal partial class QueryBuilder : IInsertCommand, IInsertIntoCommand
    {
        public IInsertIntoCommand Into(string table)
        {
            Command.AppendFormat("INSERT INTO [{0}] ", table);
            return this;
        }

        public IInsertIntoCommand Columns(params string[] columns)
        {
            Command.AppendFormat("({0}) ", columns.JoinColumns());
            return this;
        }
    }
}
