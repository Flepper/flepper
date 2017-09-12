using Flepper.QueryBuilder;
using FluentAssertions;
using Xunit;

namespace Flepper.Tests.Unit.QueryBuilder.Commands
{
    [Collection("CommandTests")]
    public class InsertCommandTests
    {

        [Fact]
        public void ShouldCreateInsertStatementWithTable()
        {
            FlepperQueryBuilder.Insert("Test")
                .Build()
                .Trim()
                .Should()
                .Be("INSERT INTO [Test]");
        }

        [Fact]
        public void ShouldCreateInsertStatementWithColumns()
        {
            FlepperQueryBuilder
                .Insert("Test", "column1", "column2")
                .Build()
                .Trim()
                .Should()
                .Be("INSERT INTO [Test] ([column1],[column2] )");
        }

        [Fact]
        public void ShouldCreateInsertStatementWithValuesToColumns()
        {
            FlepperQueryBuilder
                .Insert("Test", "column1", "column2")
                .Values("value1", 2)
                .Build()
                .Trim()
                .Should()
                .Be("INSERT INTO [Test] ([column1],[column2] ) VALUES ('value1',2)");
        }

        [Fact]
        public void ShouldCreateInsertStatementWithValues()
        {
            FlepperQueryBuilder
                .Insert("Test")
                .Values("value1", 2)
                .Build()
                .Trim()
                .Should()
                .Be("INSERT INTO [Test] VALUES ('value1',2)");
        }
    }
}
