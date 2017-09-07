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

        //TODO: Extract logic to Utils class the statement that generate fields. The statement is used by others class;
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
