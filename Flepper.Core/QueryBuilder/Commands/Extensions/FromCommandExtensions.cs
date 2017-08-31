using Flepper.Core.QueryBuilder.Commands.Interfaces;
using Flepper.Core.QueryBuilder.Filters;
using Flepper.Core.QueryBuilder.Filters.Interfaces;

namespace Flepper.Core.QueryBuilder.Commands.Extensions
{
    public static class FromCommandExtensions
    {
        public static IWhereFilter Where(this IFromCommand fromOperator, string field)
        {
            var whereFilter = new WhereFilter();
            whereFilter.Where(field);
            return whereFilter;
        }
    }
}
