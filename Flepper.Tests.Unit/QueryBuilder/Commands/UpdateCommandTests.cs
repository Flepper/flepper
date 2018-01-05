using Flepper.QueryBuilder;
using FluentAssertions;
using Xunit;
using static Flepper.QueryBuilder.FlepperQueryBuilder;
namespace Flepper.Tests.Unit.QueryBuilder.Commands
{
    [Collection("CommandTests")]
    public class UpdateCommandTests
    {
        [Fact]
        public void ShoulCreateUpdateCommand()
        {
            Update("table")
                .Build()
                .Trim()
                .Should()
                .Be("UPDATE [table]");
        }

        [Fact]
        public void ShoulCreateUpdateCommandWithTableSchema()
        {
            Update("dbo", "table")
                .Build()
                .Trim()
                .Should()
                .Be("UPDATE [dbo].[table]");
        }

        [Fact]
        public void ShouldCreateUpdateCommandWithColumnAndValue()
        {
            var queryResult = Update("dbo", "table")
                .Set("column", "value")
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("UPDATE [dbo].[table] SET [column] = @p0");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal("value", parameters.@p0);
        }

        [Fact]
        public void ShouldCreateUpdateCommandWithTwoColumnAndValues()
        {
            var queryResult = Update("dbo", "table")
                .Set("column", "value")
                .Set("column", "value")
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("UPDATE [dbo].[table] SET [column] = @p0 ,[column] = @p1");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal("value", parameters.@p0);
            Assert.Equal("value", parameters.@p1);
        }

        [Fact]
        public void ShouldCreateUpdateCommandWithMutiplesColumnAndValues()
        {
            var queryResult = Update("dbo", "table")
                .Set("column", "value")
                .Set("column", 1)
                .Set("column", true)
                .Set("column", "value")
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("UPDATE [dbo].[table] SET [column] = @p0 ,[column] = @p1 ,[column] = @p2 ,[column] = @p3");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal("value", parameters.@p0);
            Assert.Equal(1, parameters.@p1);
            Assert.Equal(true, parameters.@p2);
            Assert.Equal("value", parameters.@p3);
        }

        [Fact]
        public void ShouldCreateUpdateCommandWithWhereCondition()
        {
            var queryResult = Update("dbo", "table")
                .Set("column", "value")
                .Where("column").EqualTo("value")
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("UPDATE [dbo].[table] SET [column] = @p0 WHERE [column] = @p1");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal("value", parameters.@p0);
            Assert.Equal("value", parameters.@p1);
        }
    }
}