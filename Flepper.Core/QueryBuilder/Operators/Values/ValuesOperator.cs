using Flepper.Core.QueryBuilder.Operators.Values.Interfaces;
using Flepper.Core.Base;
using System.Linq;
using Flepper.Core.Utils.Extensions;

namespace Flepper.Core.QueryBuilder.Operators.Values
{
    internal class ValuesOperator : BaseQueryBuilder, IValuesOperator
    {
        public void Values(params object[] values)
        {
            var definedValues = values.Aggregate("", (current, value) => current + $"{value.InsertQuotationMarksIfDateOrString()},");
            definedValues = definedValues.Remove(definedValues.Length - 1, 1) + "";
            Command.AppendFormat("VALUES ({0})", definedValues);
        }
    }
}
