
using Flepper.QueryBuilder.Base;
using Flepper.QueryBuilder.Utils.Extensions;
using System.Linq;
using System.Text;

namespace Flepper.QueryBuilder
{
    internal class ValuesOperator : BaseQueryBuilder, IValuesOperator
    {
        public ValuesOperator(StringBuilder command) : base(command)
        {
        }

        public IValuesOperator Values(params object[] values)
        {
            var definedValues = values.Aggregate("", (current, value) => current + $"{value.InsertQuotationMarksIfDateOrString()},");
            definedValues = definedValues.Remove(definedValues.Length - 1, 1) + "";
            Command.AppendFormat("VALUES ({0})", definedValues);
            return this;
        }
    }
}
