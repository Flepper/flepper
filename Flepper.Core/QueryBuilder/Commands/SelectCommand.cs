using System.Linq;
using Flepper.Core.Base;
using Flepper.Core.QueryBuilder.Commands.Interfaces;

namespace Flepper.Core.QueryBuilder.Commands
{
    public class SelectCommand : BaseFlepperQueryBuilder, ISelectCommand
    {
        public ISelectCommand Select()
        {
            Command.Append("SELECT * ");
            return this;
        }

        public ISelectCommand Select(params string[] columns)
        {
            var fields = columns.Aggregate("", (current, column) => current + $"[{column}],");

            fields = fields.Remove(fields.Length - 1, 1) + " ";

            Command.AppendFormat("SELECT {0}", fields);

            return this;
        }
    }
}
