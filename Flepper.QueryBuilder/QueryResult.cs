using System.Runtime.CompilerServices;

//Using this, I can access members that are "internal" in the Test assembly
[assembly: InternalsVisibleTo("Flepper.Tests.Unit")]

namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Query Result
    /// </summary>
    public struct QueryResult
    {
        /// <summary>
        /// Query Result Constructor
        /// </summary>
        /// <param name="query">Query object</param>
        /// <param name="parameters">Query parameters</param>
        public QueryResult(string query, object parameters)
        {
            Query = query;
            Parameters = parameters;
        }

        /// <summary>
        /// Query object
        /// </summary>
        public string Query { get; }

        /// <summary>
        /// Query Parameters
        /// </summary>
        public object Parameters { get; }
    }
}