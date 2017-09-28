using System;
using System.Linq.Expressions;

namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Select Command Interface
    /// </summary>
    public interface ISelectCommand : IQueryCommand
    {
        /// <summary>
        /// Select Command Contract
        /// </summary>
        /// <returns></returns>
        ISelectCommand SelectCommand();

        /// <summary>
        /// Select Command Contract
        /// </summary>
        /// <param name="columns"></param>
        /// <returns></returns>
        ISelectCommand SelectCommand(params string[] columns);

        /// <summary>
        /// Select Command Contract
        /// </summary>
        /// <returns></returns>
        ISelectCommand SelectCommand<T>() where T : class;

        /// <summary>
        /// Select Command Contract
        /// </summary>
        /// <returns></returns>
        ISelectCommand SelectCommand<T>(Expression<Func<T, object>> expression) where T : class;
    }
}