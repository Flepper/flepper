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
            FlepperQueryBuilder.Insert().Into("Test")
                .Build()
                .Trim()
                .Should()
                .Be("INSERT INTO [Test]");
        }

        [Fact]
        public void ShouldCreateInsertStatementWithColumns()
        {
            FlepperQueryBuilder
                .Insert().Into("Test")
                .Columns("column1", "column2")
                .Build()
                .Trim()
                .Should()
                .Be("INSERT INTO [Test] ([column1],[column2] )");
        }

        [Fact]
        public void ShouldCreateInsertStatementWithValuesToColumns()
        {
            var queryResult = FlepperQueryBuilder
                .Insert().Into("Test")
                .Columns("column1", "column2")
                .Values("value1", 2)
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("INSERT INTO [Test] ([column1],[column2] ) VALUES (@p0, @p1)");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal("value1", parameters.@p0);
            Assert.Equal(2, parameters.@p1);
        }

        [Fact]
        public void ShouldCreateInsertStatementWithValues()
        {
            var queryResult = FlepperQueryBuilder
                .Insert().Into("Test")
                .Values("value1", 2)
                .BuildWithParameters();

            queryResult.Query
                .Trim()
                .Should()
                .Be("INSERT INTO [Test] VALUES (@p0, @p1)");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal("value1", parameters.@p0);
            Assert.Equal(2, parameters.@p1);
        }

        [Fact]
        public void ShouldCreateInsertStatementWithValuesToColumnsAndWithScopeIdentity()
        {
            var queryResult = FlepperQueryBuilder
                .Insert().Into("Test")
                .Columns("column1", "column2")
                .Values("value1", 100)
                .WithScopeIdentity()
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("INSERT INTO [Test] ([column1],[column2] ) VALUES (@p0, @p1);SELECT scope_identity();");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal("value1", parameters.@p0);
            Assert.Equal(100, parameters.@p1);

        }

        [Fact]
        public void ShouldCreateInsertStatementWithValuesAndWithScopeIdentity()
        {
            var queryResult = FlepperQueryBuilder
                .Insert().Into("Test")
                .Values("value1", 200)
                .WithScopeIdentity()
                .BuildWithParameters();

            queryResult.Query
                .Trim()
                .Should()
                .Be("INSERT INTO [Test] VALUES (@p0, @p1);SELECT scope_identity();");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal("value1", parameters.@p0);
            Assert.Equal(200, parameters.@p1);
        }
    }
}
