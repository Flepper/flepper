using FluentAssertions;
using Flepper.Core.QueryBuilder.Commands.Extensions;
using Xunit;
using Flepper.Core.QueryBuilder;

namespace Flepper.Tests.Unit.QueryBuilder.Commands
{
    [Collection("CommandTests")]
    public class InsertCommandTests
    {

        [Fact]
        public void ShouldCreateInsertStatementWithTable()
        {
            FlepperQueryBuilder.InsertInto("Test");

            FlepperQueryBuilder
                .Query
                .Trim()
                .Should()
                .Be("INSERT INTO [Test]");
        }

        [Fact]
        public void ShouldCreateInsertStatementWithColumns()
        {
            FlepperQueryBuilder
                .InsertInto("Test", "column1", "column2");

            FlepperQueryBuilder.Query
                .Trim()
                .Should()
                .Be("INSERT INTO [Test] (column1,column2)");
        }

        [Fact]
        public void ShouldCreateInsertStatementWithValuesToColumns()
        {
            FlepperQueryBuilder
            .InsertInto("Test", "column1", "column2")
            .Values("'value1'","2");

            FlepperQueryBuilder.Query
                .Trim()
                .Should()
                .Be("INSERT INTO [Test] (column1,column2) VALUES ('value1',2)");

        }

        [Fact]
        public void ShouldCreateInsertStatementWithValues()
        {
            FlepperQueryBuilder
            .InsertInto("Test")
            .Values("'value1'", "2");

            FlepperQueryBuilder.Query
                .Trim()
                .Should()
                .Be("INSERT INTO [Test] VALUES ('value1',2)");

        }
    }
}
