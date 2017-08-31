using Flepper.Core.QueryBuilder.Commands;
using Flepper.Core.QueryBuilder.Commands.Extensions;
using Flepper.Core.QueryBuilder.Filters.Extensions;
using Flepper.Core.QueryBuilder.Operators.Comparison.Extensions;
using Flepper.Core.QueryBuilder.Operators.Logical.Extensions;
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
            var selectCommand = new SelectCommand();

            selectCommand.Select().From("user").Where("name");

            selectCommand.Query
                .Trim()
                .Should()
                .Contain("WHERE");
        }

        [Fact]
        public void ShouldContainsWhereWithComparisonOperatos()
        {
            var selectCommand = new SelectCommand();

            selectCommand.Select()
                .From("user")
                .Where("name")
                .Equal("gustavo");

            selectCommand.Query
                .Trim()
                .Should()
                .Contain("WHERE [name] = 'gustavo'");
        }

        [Fact]
        public void ShouldContainsWhereWithLogicalOperator()
        {
            var selectCommand = new SelectCommand();

            selectCommand.Select()
                .From("user")
                .Where("name")
                .Equal("gustavo")
                .And("age");

            selectCommand.Query
                .Trim()
                .Should()
                .Contain("WHERE [name] = 'gustavo' AND [age]");
        }

        [Fact]
        public void ShouldContainsWhereWithLogicalOperatorWithComparisonOperators()
        {
            var selectCommand = new SelectCommand();

            selectCommand.Select()
                .From("user")
                .Where("name")
                .Equal("gustavo")
                .And("age")
                .Equal(26);

            selectCommand.Query
                .Trim()
                .Should()
                .Contain("WHERE [name] = 'gustavo' AND [age] = 26");
        }
    }
}
