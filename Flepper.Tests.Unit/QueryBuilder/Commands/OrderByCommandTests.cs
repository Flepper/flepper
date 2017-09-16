using Flepper.QueryBuilder;
using FluentAssertions;
using Xunit;

namespace Flepper.Tests.Unit.QueryBuilder.Commands
{
    [Collection("CommandTests")]
    public class OrderByCommandTests
    {
        [Fact]
        public void ShouldCreateSelectWithOrderByStatement()
        {
             FlepperQueryBuilder.Select("Id", "Name", "Birthday")
                .From("user")
                .OrderBy("Name")
                .Build()
                .Trim()
                .Should()
                .Be("SELECT [Id],[Name],[Birthday] FROM [user] ORDER BY [Name]");
        }

        [Fact]
        public void ShouldCreateSelectWithOrderByDescStatement()
        {
            FlepperQueryBuilder.Select("Id", "Name", "Birthday")
               .From("user")
               .OrderByDesc("Name","Birthday")
               .Build()
               .Trim()
               .Should()
               .Be("SELECT [Id],[Name],[Birthday] FROM [user] ORDER BY [Name],[Birthday] DESC");
        }
    }
}