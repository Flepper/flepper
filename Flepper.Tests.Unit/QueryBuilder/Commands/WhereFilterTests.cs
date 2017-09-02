using Flepper.Core.QueryBuilder;
using FluentAssertions;
using Xunit;

namespace Flepper.Tests.Unit.QueryBuilder.Commands
{
    [Collection("CommandTests")]
    public class WhereFilterTests
    {
        [Fact]
        public void ShouldContainsWhereInStatement()
        {
            FlepperQueryBuilder.Select()
                .From("user").Where("name");

            FlepperQueryBuilder.Query
                .Trim()
                .Should()
                .Contain("WHERE");
        }

        [Fact]
        public void ShouldContainsWhereWithComparisonOperatos()
        {
            FlepperQueryBuilder.Select()
                .From("user")
                .Where("name")
                .EqualTo("gustavo");

            FlepperQueryBuilder.Query
                .Trim()
                .Should()
                .Contain("WHERE [name] = 'gustavo'");
        }

        [Fact]
        public void ShouldContainsWhereWithLogicalOperator()
        {
            FlepperQueryBuilder.Select()
                .From("user")
                .Where("name")
                .EqualTo("gustavo")
                .And("age");

            FlepperQueryBuilder.Query
                .Trim()
                .Should()
                .Contain("WHERE [name] = 'gustavo' AND [age]");
        }

        [Fact]
        public void ShouldContainsWhereWithLogicalOperatorWithComparisonOperators()
        {
            FlepperQueryBuilder.Select()
                .From("user")
                .Where("name")
                .EqualTo("gustavo")
                .And("age")
                .EqualTo(26);

            FlepperQueryBuilder.Query
                .Trim()
                .Should()
                .Contain("WHERE [name] = 'gustavo' AND [age] = 26");
        }
    }
}
