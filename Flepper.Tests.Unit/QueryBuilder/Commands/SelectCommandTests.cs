using Flepper.Core.QueryBuilder;
using Flepper.Core.QueryBuilder.Commands.Extensions;
using FluentAssertions;
using Xunit;

namespace Flepper.Tests.Unit.QueryBuilder.Commands
{
    [Collection("CommandTests")]
    public class SelectCommandTests
    {
        [Fact]
        public void ShouldCreateSelectStatementForAllColumns()
        {
            var selectCommand = new SelectCommand();

            selectCommand.Select().From("user");
            selectCommand.Query.Trim()
                .Should()
                .Be("SELECT * FROM [user]");
        }

        [Fact]
        public void ShouldCreateSelectStatementWithSpecificColumns()
        {
            var selectCommand = new SelectCommand();

            selectCommand.Select("Id", "Name", "Birthday").From("user");
            selectCommand.Query.Trim()
                .Should()
                .Be("SELECT [Id],[Name],[Birthday] FROM [user]");
        }

        [Fact]
        public void ShouldCreteSelectWithWhereCondition()
        {
            var selectCommand = new SelectCommand();

            selectCommand.Select("Id", "Name", "Birthday").From("user").Where("Name").Equal("Nicolas");

            selectCommand.Query
                .Trim()
                .Should()
                .Be("SELECT [Id],[Name],[Birthday] FROM [user] WHERE [Name] = 'Nicolas'");
        }

        [Fact]
        public void ShouldCreateSelectStatementWithSchema()
        {
            var selectCommand = new SelectCommand();

            selectCommand.Select().From("dbo", "user");

            selectCommand.Query
                .Trim()
                .Should()
                .Be("SELECT * FROM [dbo].[user]");

        }
    }
}