using Flepper.Core.Base;

namespace Flepper.Core.QueryBuilder.Join.Operators
{
    public class OnOperator :BaseFlepperQueryBuilder, IIOnOperator
    {
        public void On(string column)
        {
            Command.AppendFormat("ON [{0}] ", column);
        }
    }
}
