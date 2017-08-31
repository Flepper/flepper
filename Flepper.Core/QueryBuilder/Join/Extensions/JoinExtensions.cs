using Flepper.Core.QueryBuilder.Join.Interfaces;
using Flepper.Core.QueryBuilder.Join.Operators;

namespace Flepper.Core.QueryBuilder.Join.Extensions
{
    public static class JoinExtensions
    {
        public static IIOnOperator On(this IJoin join, string column)
        {
            var onOperator = new OnOperator();
            onOperator.On(column);
            return onOperator;
        }
    }
}
