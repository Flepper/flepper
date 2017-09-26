using Flepper.QueryBuilder.Base;
using System;
using System.Collections.Generic;
using System.Text;

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
