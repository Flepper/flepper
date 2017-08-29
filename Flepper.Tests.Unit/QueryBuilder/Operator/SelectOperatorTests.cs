using Flepper.Core.QueryBuilder.Operators;
using Flepper.Core.QueryBuilder.Operators.Extensions;
using FluentAssertions;
using Xunit;

namespace Flepper.Tests.Unit.QueryBuilder.Operator
{
    public class SelectOperatorTests
    {
        [Fact]
        public void ShouldCreateSelectStatementForAllColumns()
        {
            var selectOperator = new SelectOperator();

            selectOperator.Select().From("user");

            var query = selectOperator.SqlQuery;

            query.Trim()
                .Should()
                .Be("SELECT * FROM [user]");
        }

        [Fact]
        public void ShouldCreateSelectStatementWithSpecificColumns()
        {
            var selectOperator = new SelectOperator();

            selectOperator.Select("Id", "Name", "Birthday").From("User");

            var query = selectOperator.SqlQuery;

            query.Trim()
                .Should()
                .Be("SELECT [Id],[Name],[Birthday] FROM [user]");
        }
    }
}