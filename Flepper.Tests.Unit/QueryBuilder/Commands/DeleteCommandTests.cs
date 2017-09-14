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
            FlepperQueryBuilder.Delete().From("Test")
                .Build()
                .Trim()
                .Should()
                .Be("DELETE FROM [Test]");
        }

        [Fact]
        public void ShouldCreateDeleteStatementWithWhere()
        {
            var build = FlepperQueryBuilder.Delete()
                .From("Test")
                .Where("Id")
                .EqualTo(2)
                .BuildWithParameters();

            build.Query
                .Trim()
                .Should()
                .Be("DELETE FROM [Test] WHERE [Id] = @p0");

            dynamic parameters = build.Parameters;

            Assert.Equal(2, parameters.@p0);
        }
    }
}
