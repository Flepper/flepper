using Flepper.QueryBuilder;
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
            FlepperQueryBuilder.Select().From("user");
            FlepperQueryBuilder.Build();
            FlepperQueryBuilder.Query
                .Trim()
                .Should()
                .Be("SELECT * FROM [user]");
        }

        [Fact]
        public void ShouldCreateSelectStatementWithSpecificColumns()
        {
            FlepperQueryBuilder.Select("Id", "Name", "Birthday")
                .From("user");
            FlepperQueryBuilder.Build();
            FlepperQueryBuilder.Query
                .Trim()
                .Should()
                .Be("SELECT [Id],[Name],[Birthday] FROM [user]");
        }

        [Fact]
        public void ShouldCreteSelectWithWhereCondition()
        {
            FlepperQueryBuilder.Select("Id", "Name", "Birthday")
                .From("user")
                .Where("Name").EqualTo("Nicolas");
            FlepperQueryBuilder.Build();
            FlepperQueryBuilder.Query
                .Trim()
                .Should()
                .Be("SELECT [Id],[Name],[Birthday] FROM [user] WHERE [Name] = 'Nicolas'");
        }

        [Fact]
        public void ShouldCreateSelectStatementWithSchema()
        {
            FlepperQueryBuilder.Select()
                .From("dbo", "user");
            FlepperQueryBuilder.Build();
            FlepperQueryBuilder.Query
                .Trim()
                .Should()
                .Be("SELECT * FROM [dbo].[user]");
        }
    }
}