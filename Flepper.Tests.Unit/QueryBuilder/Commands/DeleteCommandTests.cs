using Flepper.Core.QueryBuilder;
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
            var deleteCommand = new DeleteCommand();

            deleteCommand.Delete().From("Test");

            deleteCommand.Query.Trim()
                .Should()
                .Be("DELETE FROM [Test]");
        }

        [Fact]
        public void ShouldCreateDeleteStatementWithWhere()
        {
            var command = new DeleteCommand();

            command.Delete()
                .From("Test")
                .Where("Id")
                .Equal(2);

            command
                .Query
                .Trim()
                .Should()
                .Be("DELETE FROM [Test] WHERE [Id] = 2");
        }
    }
}
