
namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Join Extensions
    /// </summary>
    public static class JoinExtensions
    {
        /// <summary>
        /// Add Alias to table
        /// </summary>
        /// <param name="join">Join instance</param>
        /// <param name="alias">Table Alias</param>
        /// <returns></returns>
        public static IAliasOperator As(this IJoin join, string alias)
            => join.To<AliasOperator>().As(alias);
    }
}
