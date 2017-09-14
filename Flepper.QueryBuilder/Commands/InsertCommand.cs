using Flepper.QueryBuilder.Base;
using Flepper.QueryBuilder.Utils.Extensions;

namespace Flepper.QueryBuilder
{
    internal class InsertCommand : BaseQueryBuilder, IInsertCommand
    {
        public IInsertCommand Into(string table)
        {
            Command.AppendFormat("INSERT INTO [{0}] ", table);
            return this;
        }

        public IInsertCommand Into(string table, string[] columns)
        {
            Command.AppendFormat("INSERT INTO [{0}] ({1}) ", table, columns.JoinColumns());
            return this;
        }
    }
}
