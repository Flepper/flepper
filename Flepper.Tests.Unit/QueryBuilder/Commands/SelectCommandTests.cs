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
            FlepperQueryBuilder.Select().From("user")
                .Build()
                .Trim()
                .Should()
                .Be("SELECT * FROM [user]");
        }

        [Fact]
        public void ShouldCreateSelectStatementWithSpecificColumns()
        {
            FlepperQueryBuilder.Select("Id", "Name", "Birthday")
                .From("user")
                .Build()
                .Trim()
                .Should()
                .Be("SELECT [Id],[Name],[Birthday] FROM [user]");
        }

        [Fact]
        public void ShouldCreteSelectWithWhereCondition()
        {
            FlepperQueryBuilder.Select("Id", "Name", "Birthday")
                .From("user")
                .Where("Name").EqualTo("Nicolas")
                .Build()
                .Trim()
                .Should()
                .Be("SELECT [Id],[Name],[Birthday] FROM [user] WHERE [Name] = 'Nicolas'");
        }

        [Fact]
        public void ShouldCreateSelectStatementWithSchema()
        {
            FlepperQueryBuilder.Select()
                .From("dbo", "user")
                .Build()
                .Trim()
                .Should()
                .Be("SELECT * FROM [dbo].[user]");
        }

        [Fact]
        public void ShouldCreateSelectTop1StatementForAllColumns()
        {
            FlepperQueryBuilder.Select().Top().From("user")
                .Build()
                .Trim()
                .Should()
                .Be("SELECT TOP 1 * FROM [user]");
        }

        [Fact]
        public void ShouldCreteSelectTop1WithWhereCondition()
        {
            FlepperQueryBuilder.Select("Id", "Name", "Birthday")
                .Top()
                .From("user")
                .Where("Name").EqualTo("Nicolas")
                .Build()
                .Trim()
                .Should()
                .Be("SELECT TOP 1 [Id],[Name],[Birthday] FROM [user] WHERE [Name] = 'Nicolas'");
        }

        [Fact]
        public void ShouldCreateSelectTop5StatementForAllColumns()
        {
            FlepperQueryBuilder.Select().Top(5).From("user")
                .Build()
                .Trim()
                .Should()
                .Be("SELECT TOP 5 * FROM [user]");
        }

        [Fact]
        public void ShouldCreteSelectTop5WithWhereCondition()
        {
            FlepperQueryBuilder.Select("Id", "Name", "Birthday")
                .Top(5)
                .From("user")
                .Where("Name").EqualTo("Nicolas")
                .Build()
                .Trim()
                .Should()
                .Be("SELECT TOP 5 [Id],[Name],[Birthday] FROM [user] WHERE [Name] = 'Nicolas'");
        }
    }
}