using System;
namespace Flepper.QueryBuilder
{
    /// <summary>
    /// 
    /// </summary>
    public struct QueryBuilderParamenter<T>
    {
        /// <summary>
        /// 
        /// </summary>
        public T Value { get; }

        /// <summary>
        /// 
        /// </summary>
        public Type ParameterType { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public QueryBuilderParamenter(T value)
        {
            Value = value;
            ParameterType = typeof(T);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static explicit operator System.Type(QueryBuilderParamenter<T> value)
        {
            return value.ParameterType;
        }
    }
}
