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
        public void ShouldCreateInsertStatementWithColumnsArray()
        {
            FlepperQueryBuilder
                .Insert().Into("Test")
                .Columns(new[] { "column1", "column2" })
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

        [Fact]
        public void ShouldCreateInsertStatementWithValuesAndNullValueToColumns()
        {
            var queryResult = FlepperQueryBuilder
                .Insert().Into("Test")
                .Columns("column1", "column2", "column3")
                .Values("value1", FlepperQueryBuilder.NullValueString(), FlepperQueryBuilder.NullValue<System.DateTime>())
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("INSERT INTO [Test] ([column1],[column2],[column3] ) VALUES (@p0, @p1, @p2)");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal("value1", parameters.@p0);
            Assert.Equal(null, parameters.@p1);
            Assert.Equal(null, parameters.@p2);
        }

        [Fact]
        public void ShouldCreateInsertStatementWithSelectQueryBuilder()
        {
            var querySelect = FlepperQueryBuilder
                .Select(new string[] { "column1", "column2" })
                .From("Test2");

            var queryResult = FlepperQueryBuilder
                .Insert()
                .Into("Test")
                .Columns(new string[] { "column1", "column2" }, x => querySelect)
                .BuildWithParameters();

            Assert.Equal("INSERT INTO [Test] ([column1],[column2] ) SELECT [column1],[column2] FROM [Test2] ", queryResult.Query);
        }

        [Fact]
        public void ShouldCreateInsertStatementWithSelectQueryBuilderWithWhere()
        {
            var querySelect = FlepperQueryBuilder
                .Select(new string[] { "column1", "column2" })
                .From("Test2")
                .Where("Id").EqualTo(1);

            var queryResult = FlepperQueryBuilder
                .Insert()
                .Into("Test")
                .Columns(new string[] { "column1", "column2" }, x => querySelect)                
                .BuildWithParameters();

            Assert.Equal("INSERT INTO [Test] ([column1],[column2] ) SELECT [column1],[column2] FROM [Test2] WHERE [Id] = @p0 ", queryResult.Query);

            dynamic parameters = queryResult.Parameters;
            Assert.Equal(1, parameters.@p0);
        }

    }
}
