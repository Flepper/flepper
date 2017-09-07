using Flepper.Core.QueryBuilder.Operators.Values.Interfaces;
using Flepper.Core.Base;
using System.Linq;

namespace Flepper.Core.QueryBuilder.Operators.Values
{
    public class ValuesOperator : BaseFlepperQueryBuilder, IValuesOperator
    {
        public void Values(params string[] values)
        {
            var definedValues = values.Aggregate("", (current, value) => current + $"{value},");
            definedValues = definedValues.Remove(definedValues.Length - 1, 1) + "";

            Command.AppendFormat("VALUES ({0})", definedValues);

        }

        
    }
}
