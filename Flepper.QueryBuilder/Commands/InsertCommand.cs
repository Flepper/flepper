using Flepper.QueryBuilder.Base;
using Flepper.QueryBuilder.Utils.Extensions;

namespace Flepper.QueryBuilder
{
    internal class InsertCommand : BaseQueryBuilder, IInsertCommand
    {
        public InsertCommand(string table) 
            => Command.AppendFormat("INSERT INTO [{0}] ", table);

        public InsertCommand(string table, string[] columns) 
            => Command.AppendFormat("INSERT INTO [{0}] ({1}) ", table, columns.JoinColumns());
    }
}
