using System.Linq;
using Flepper.Core.Base;
using Flepper.Core.QueryBuilder.Operators.Interfaces;

namespace Flepper.Core.QueryBuilder.Operators
{
    public class SelectOperator : BaseFlepper, ISelectOperator
    {
        public ISelectOperator Select()
        {
            Command.Append("SELECT * ");

            return this;
        }

        public ISelectOperator Select(params string[] columns)
        {
            var fields = columns.Aggregate("", (current, column) => current + $"[{column}],");

            fields = fields.Remove(fields.Length - 1, 1) + " ";

            Command.AppendFormat("SELECT {0}", fields);

            return this;
        }
    }
}
