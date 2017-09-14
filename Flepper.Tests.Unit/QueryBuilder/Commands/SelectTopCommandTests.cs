using Flepper.QueryBuilder;
using FluentAssertions;
using Xunit;

namespace Flepper.Tests.Unit.QueryBuilder.Commands
{
    [Collection("CommandTests")]
    public class SelectTopCommandTests
    {
        [Fact]
        public void ShouldCreateSelectTop1StatementForAllColumns()
        {
            FlepperQueryBuilder.SelectTop().From("user")
                .Build()
                .Trim()
                .Should()
                .Be("SELECT TOP 1 * FROM [user]");
        }

        [Fact]
        public void ShouldCreateSelectTop1StatementWithSpecificColumns()
        {
            FlepperQueryBuilder.SelectTop("Id", "Name", "Birthday")
                .From("user")
                .Build()
                .Trim()
                .Should()
                .Be("SELECT TOP 1 [Id],[Name],[Birthday] FROM [user]");
        }

        [Fact]
        public void ShouldCreteSelecTop1tWithWhereCondition()
        {
            FlepperQueryBuilder.SelectTop("Id", "Name", "Birthday")
                .From("user")
                .Where("Name").EqualTo("Renan")
                .Build()
                .Trim()
                .Should()
                .Be("SELECT TOP 1 [Id],[Name],[Birthday] FROM [user] WHERE [Name] = 'Renan'");
        }

        [Fact]
        public void ShouldCreateSelectTop1StatementWithSchema()
        {
            FlepperQueryBuilder.SelectTop()
                .From("dbo", "user")
                .Build()
                .Trim()
                .Should()
                .Be("SELECT TOP 1 * FROM [dbo].[user]");
        }

        [Fact]
        public void ShouldCreateSelectTop5StatementForAllColumns()
        {
            FlepperQueryBuilder.SelectTop(5).From("user")
                .Build()
                .Trim()
                .Should()
                .Be("SELECT TOP 5 * FROM [user]");
        }

        [Fact]
        public void ShouldCreateSelectTop5StatementWithSpecificColumns()
        {
            FlepperQueryBuilder.SelectTop(5, "Id", "Name", "Birthday")
                .From("user")
                .Build()
                .Trim()
                .Should()
                .Be("SELECT TOP 5 [Id],[Name],[Birthday] FROM [user]");
        }

        [Fact]
        public void ShouldCreteSelecTop5tWithWhereCondition()
        {
            FlepperQueryBuilder.SelectTop(5, "Id", "Name", "Birthday")
                .From("user")
                .Where("Name").EqualTo("Renan")
                .Build()
                .Trim()
                .Should()
                .Be("SELECT TOP 5 [Id],[Name],[Birthday] FROM [user] WHERE [Name] = 'Renan'");
        }

        [Fact]
        public void ShouldCreateSelectTop5StatementWithSchema()
        {
            FlepperQueryBuilder.SelectTop(5)
                .From("dbo", "user")
                .Build()
                .Trim()
                .Should()
                .Be("SELECT TOP 5 * FROM [dbo].[user]");
        }
    }
}