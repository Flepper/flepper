using Flepper.Core.Base;
using Flepper.Core.QueryBuilder.Commands.Interfaces;
using Flepper.Core.Utils.Extensions;

namespace Flepper.Core.QueryBuilder
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
