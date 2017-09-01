
namespace Flepper.Core.QueryBuilder
{
    public static class JoinExtensions
    {
        public static IAliasOperator As(this IJoin join, string alias)
        {
            var aliasOperator = new AliasOperator();

            aliasOperator.As(alias);

            return aliasOperator;
        }
    }
}
