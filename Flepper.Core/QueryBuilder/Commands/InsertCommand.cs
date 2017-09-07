using System;
using Flepper.Core.Base;
using Flepper.Core.QueryBuilder.Commands.Interfaces;
using System.Linq;

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

            var fields = columns
              .Aggregate("", (current, column) => current + $"{column},");
            fields = fields.Remove(fields.Length - 1, 1) + "";

            Command.AppendFormat("INSERT INTO [{0}] ({1}) ", table, fields);

            return this;
        }
    }
}
