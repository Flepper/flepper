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
       where T: struct
    {
        /// <summary>
        /// Create QueryBuilderParamenter
        /// </summary>
        /// <param name="value"></param>
        public QueryBuilderParameter(T? value = default)          
        {
            Value = value;
            ParameterType = typeof(T?);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public QueryBuilderParameter(string value = null)
        {
            Value = value;
            ParameterType = typeof(System.String);
        }

        /// <summary>
        /// 
        /// </summary>
        public object Value { get; }

        /// <summary>
        /// 
        /// </summary>
        public Type ParameterType { get; }
    }
}
