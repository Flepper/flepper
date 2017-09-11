using Flepper.QueryBuilder;
using FluentAssertions;
using Xunit;

namespace Flepper.Tests.Unit.QueryBuilder.Commands
{
    [Collection("CommandTests")]
    public class DeleteCommandTests
    {

        [Fact]
        public void ShouldCreateDeleteStatement()
        {
            FlepperQueryBuilder.Delete().From("Test");

            FlepperQueryBuilder.Query
                .Trim() 
                .Should()
                .Be("DELETE FROM [Test]");
        }

        [Fact]
        public void ShouldCreateDeleteStatementWithWhere()
        {
            FlepperQueryBuilder.Delete()
                .From("Test")
                .Where("Id")
                .EqualTo(2);

            FlepperQueryBuilder.Query
                .Trim()
                .Should()
                .Be("DELETE FROM [Test] WHERE [Id] = 2");
        }
    }
}
