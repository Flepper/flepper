using System;
using Flepper.Core.Base;
using Flepper.Core.QueryBuilder.Commands.Interfaces;
using System.Linq;
using Flepper.Core.Utils.Extensions;

namespace Flepper.Core.QueryBuilder.Commands
{
    public class InsertCommand : BaseFlepperQueryBuilder, IInsertCommand
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
