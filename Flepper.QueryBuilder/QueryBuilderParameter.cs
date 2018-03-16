using System;
namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Interface IQueryBuilderParamenter
    /// </summary>
    public interface IQueryBuilderParameter
    {
        /// <summary>
        /// 
        /// </summary>
        object Value { get; }

        /// <summary>
        /// 
        /// </summary>
        Type ParameterType { get; }
    }

    /// <summary>
    /// 
    /// </summary>
    public sealed class QueryBuilderParameter<T> : IQueryBuilderParameter
    {
        /// <summary>
        /// Create QueryBuilderParamenter
        /// </summary>
        /// <param name="value"></param>
        public QueryBuilderParameter(T value)
        {
            Value = value;
            ParameterType = typeof(T);
        }

        /// <summary>
        /// 
        /// </summary>
        public object Value { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Type ParameterType { get; private set; }
    }
}
