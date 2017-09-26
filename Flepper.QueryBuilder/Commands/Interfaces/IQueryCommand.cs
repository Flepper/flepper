using System;
using System.Collections.Generic;
using System.Text;
using Flepper.QueryBuilder.Base;

namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Query Command Interface
    /// </summary>
    public interface IQueryCommand
    {
        /// <summary>
        /// Build a query
        /// </summary>
        /// <returns></returns>
        string Build();

        /// <summary>
        /// Build a query with parameters
        /// </summary>
        /// <returns></returns>
        QueryResult BuildWithParameters();

        /// <summary>
        /// Map Query to a Command
        /// </summary>
        /// <typeparam name="TEnd"></typeparam>
        /// <returns></returns>
        TEnd To<TEnd>() where TEnd : IQueryCommand;

        /// <summary>
        /// Map Query to a Command
        /// </summary>
        /// <typeparam name="TEnd"></typeparam>
        /// <returns></returns>
        TEnd To<TEnd>(Func<StringBuilder, IDictionary<string, object>, SqlColumn[], TEnd> creator);
    }
}
