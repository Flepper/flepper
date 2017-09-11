using Flepper.QueryBuilder.Base;
using Flepper.QueryBuilder.Utils.Extensions;

namespace Flepper.QueryBuilder
{
    internal class InsertCommand : BaseQueryBuilder, IInsertCommand
    {
        public IInsertCommand Insert(string table)
        {
            BeforeExecute();

            Command.AppendFormat("INSERT INTO [{0}] ", table);

            return this;
        }

        public IInsertCommand Insert(string table, string[] columns)
        {
            BeforeExecute();

            Command.AppendFormat("INSERT INTO [{0}] ({1}) ", table, columns.JoinColumns());

            return this;
        }
    }
}
