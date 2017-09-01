using System.Linq;
using Flepper.Core.Base;

namespace Flepper.Core.QueryBuilder
{
    public class SelectCommand : BaseFlepperQueryBuilder, ISelectCommand
    {
        public ISelectCommand Select()
        {
            BeforeExecute();

            Command.Append("SELECT * ");
            return this;
        }

        public ISelectCommand Select(params string[] columns)
        {
            BeforeExecute();

            var fields = columns.Aggregate("", (current, column) => current + $"[{column}],");

            fields = fields.Remove(fields.Length - 1, 1) + " ";

            Command.AppendFormat("SELECT {0}", fields);

            return this;
        }
    }
}
