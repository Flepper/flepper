
namespace Flepper.QueryBuilder
{
    public static class JoinExtensions
    {
        public static IAliasOperator As(this IJoin join, string alias)
            => join.To<AliasOperator>().As(alias);
    }
}
