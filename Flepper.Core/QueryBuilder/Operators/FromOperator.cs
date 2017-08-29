using Flepper.Core.Base;
using Flepper.Core.QueryBuilder.Operators.Interfaces;

namespace Flepper.Core.QueryBuilder.Operators
{
    public class FromOperator : BaseFlepper, IFromOperator
    {
        public void From(string schema, string table)
        {
        }

        public void From(string table)
        {
            Command.AppendFormat("FROM [{0}] ", table).AppendLine();
        }
    }
}
