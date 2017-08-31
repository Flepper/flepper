using Flepper.Core.QueryBuilder.Commands;
using Flepper.Core.QueryBuilder.Commands.Extensions;
using Flepper.Core.QueryBuilder.Filters.Extensions;
using FluentAssertions;
using Xunit;

namespace Flepper.Tests.Unit.QueryBuilder.Commands
{
    public class SelectCommandTests
    {
        [Fact]
        public void ShouldCreateSelectStatementForAllColumns()
        {
            var selectOperator = new SelectCommand();

            selectOperator.Select().From("user");
            selectOperator.SqlQuery
                .Trim()
                .Should()
                .Be("SELECT * FROM [user]");

            selectOperator.ExecuteQuery();
        }

        [Fact]
        public void ShouldCreateSelectStatementWithSpecificColumns()
        {
            var selectOperator = new SelectCommand();

            selectOperator.Select("Id", "Name", "Birthday").From("user");
            selectOperator.SqlQuery
                .Trim()
                .Should()
                .Be("SELECT [Id],[Name],[Birthday] FROM [user]");

            selectOperator.ExecuteQuery();
        }

        [Fact]
        public void ShouldCreteSelectWithWhereCondition()
        {
            var selectOperator = new SelectCommand();
            selectOperator.Select("Id", "Name", "Birthday").From("user").Where("Name").Equal("Nicolas");
            selectOperator.SqlQuery
                .Trim()
                .Should()
                .Be("SELECT [Id],[Name],[Birthday] FROM [user] WHERE [Name] = 'Nicolas'");

            selectOperator.ExecuteQuery();
        }
    }
}