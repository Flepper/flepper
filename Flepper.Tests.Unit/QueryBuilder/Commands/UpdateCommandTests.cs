using Flepper.QueryBuilder;
using FluentAssertions;
using Xunit;

namespace Flepper.Tests.Unit.QueryBuilder.Commands
{
    [Collection("CommandTests")]
    public class UpdateCommandTests
    {
        [Fact]
        public void ShoulCreateUpdateCommand()
        {
            FlepperQueryBuilder.Update("table");
            FlepperQueryBuilder.Build();
            FlepperQueryBuilder.Query
                .Trim()
                .Should()
                .Be("UPDATE [table]");
        }

        [Fact]
        public void ShoulCreateUpdateCommandWithTableSchema()
        {
            FlepperQueryBuilder.Update("dbo","table");
            FlepperQueryBuilder.Build();
            FlepperQueryBuilder.Query
                .Trim()
                .Should()
                .Be("UPDATE [dbo].[table]");
        }

        [Fact]
        public void ShouldCreateUpdateCommandWithColumnAndValue()
        {
            FlepperQueryBuilder.Update("dbo", "table")
                .Set("column","value");
            FlepperQueryBuilder.Build();
            FlepperQueryBuilder.Query
                .Trim()
                .Should()
                .Be("UPDATE [dbo].[table] SET [column] = 'value'");
        }

        [Fact]
        public void ShouldCreateUpdateCommandWithTwoColumnAndValues()
        {
            FlepperQueryBuilder.Update("dbo", "table")
                .Set("column", "value")
                .Set("column", "value");
            FlepperQueryBuilder.Build();
            FlepperQueryBuilder.Query
                .Trim()
                .Should()
                .Be("UPDATE [dbo].[table] SET [column] = 'value' ,[column] = 'value'");
        }

        [Fact]
        public void ShouldCreateUpdateCommandWithMutiplesColumnAndValues()
        {
            FlepperQueryBuilder.Update("dbo", "table")
                .Set("column", "value")
                .Set("column", "value")
                .Set("column", "value")
                .Set("column", "value");
            FlepperQueryBuilder.Build();
            FlepperQueryBuilder.Query
                .Trim()
                .Should()
                .Be("UPDATE [dbo].[table] SET [column] = 'value' ,[column] = 'value' ,[column] = 'value' ,[column] = 'value'");
        }

        [Fact]
        public void ShouldCreateUpdateCommandWithWhereCondition()
        {
            FlepperQueryBuilder.Update("dbo", "table")
                .Set("column", "value")
                .Where("column").EqualTo("value");
            FlepperQueryBuilder.Build();
            FlepperQueryBuilder.Query
                .Trim()
                .Should()
                .Be("UPDATE [dbo].[table] SET [column] = 'value' WHERE [column] = 'value'");
        }
    }
}
