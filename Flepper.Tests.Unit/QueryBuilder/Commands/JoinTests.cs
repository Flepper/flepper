using Flepper.QueryBuilder;
using FluentAssertions;
using Xunit;
using static Flepper.QueryBuilder.FlepperQueryFunction;
namespace Flepper.Tests.Unit.QueryBuilder.Commands
{
    [Collection("CommandTests")]
    public class JoinTests
    {
        [Fact]
        public void ShouldReturnInnerJoinStatement()
        {

            FlepperQueryBuilder.Select()
                .From("Table1").As("t1")
                .InnerJoin("Table2").As("t2")
                .Build()
                .Trim()
                .Should()
                .Contain("INNER JOIN [Table2] AS t2");
        }


        [Fact]
        public void ShouldReturnInnerJoinStatementWishTableAlias()
        {
            FlepperQueryBuilder
                .Select(
                        AsFrom("t1", "c1"),
                        AsFrom("t2", "c1"))
               .From("Table1").As("t1")
               .InnerJoin("Table2").As("t2")
               .On("t1", "c1").EqualTo("t2", "c1")
               .Build()
               .Trim()
               .Should()
               .Be("SELECT [t1].[c1],[t2].[c1] FROM [Table1] AS t1 INNER JOIN [Table2] AS t2 ON [t1].[c1] = [t2].[c1]");
        }

        [Fact]
        public void ShouldReturnInnerJoinsStatement()
        {
            FlepperQueryBuilder
                .Select()
                .From("Table1").As("t1")
                .InnerJoin("Table2").As("t2")
                .On("t1", "c1").EqualTo("t2", "c1")
                .InnerJoin("Table3").As("t3")
                .On("t2", "c2").EqualTo("t3", "c3")
                .Build()
                .Trim()
                .Should()
                .Be("SELECT * FROM [Table1] AS t1 INNER JOIN [Table2] AS t2 ON [t1].[c1] = [t2].[c1] INNER JOIN [Table3] AS t3 ON [t2].[c2] = [t3].[c3]");
        }

        [Fact]
        public void ShouldReturnInnerJoinWithOnEqualStatement()
        {
            FlepperQueryBuilder.Select()
                .From("Table1").As("t1")
                .InnerJoin("Table2").As("t2")
                .On("t2", "column1")
                .EqualTo("t1", "column2")
                .Build()
                .Trim()
                .Should()
                .Contain("INNER JOIN [Table2] AS t2 ON [t2].[column1] = [t1].[column2]");
        }

        [Fact]
        public void ShouldReturnInnerJoinWithOnNotEqualStatement()
        {
            FlepperQueryBuilder.Select()
                .From("Table1").As("t1")
                .InnerJoin("Table2").As("t2")
                .On("t2", "column1")
                .NotEqualTo("t1", "column2")
                .Build()
                .Trim()
                .Should()
                .Contain("INNER JOIN [Table2] AS t2 ON [t2].[column1] <> [t1].[column2]");
        }

        [Fact]
        public void ShouldReturnInnerJoinWithWhereStatement()
        {
            var queryResult = FlepperQueryBuilder
                .Select()
                .From("Table1").As("t1")
                .InnerJoin("Table2").As("t2")
                .On("t2", "column1")
                .NotEqualTo("t1", "column2")
                .Where("t1", "name").EqualTo("table")
                .BuildWithParameters();

            queryResult.Query
            .Trim()
            .Should()
            .Be("SELECT * FROM [Table1] AS t1 INNER JOIN [Table2] AS t2 ON [t2].[column1] <> [t1].[column2] WHERE [t1].[name] = @p0");
            dynamic parameters = queryResult.Parameters;

            Assert.Equal("table", parameters.@p0);
        }

        [Fact]
        public void ShouldReturnInnerJoinWithMultipleWhereStatement()
        {
            var queryResult = FlepperQueryBuilder
                .Select()
                .From("Table1").As("t1")
                .InnerJoin("Table2").As("t2")
                .On("t2", "column1")
                .NotEqualTo("t1", "column2")
                .Where("t1", "name").EqualTo("table")
                .And("t2", "c2").EqualTo("c2")
                .Or("t2", "c2").EqualTo("c3")
                .BuildWithParameters();

            queryResult.Query
                .Trim()
                .Should()
                .Be("SELECT * FROM [Table1] AS t1 INNER JOIN [Table2] AS t2 ON [t2].[column1] <> [t1].[column2] WHERE [t1].[name] = @p0 AND [t2].[c2] = @p1 OR [t2].[c2] = @p2");
            dynamic parameters = queryResult.Parameters;

            Assert.Equal("table", parameters.@p0);
        }
        [Fact]
        public void ShouldReturnInnerAndLeftJoinStatement()
        {
            FlepperQueryBuilder
                .Select()
                .From("Table1").As("t1")
                .InnerJoin("Table2").As("t2")
                .On("t1", "c1").EqualTo("t2", "c1")
                .LeftJoin("Table3").As("t3")
                .On("t2", "c2").EqualTo("t3", "c3")
                .Build()
                .Trim()
                .Should()
                .Be("SELECT * FROM [Table1] AS t1 INNER JOIN [Table2] AS t2 ON [t1].[c1] = [t2].[c1] LEFT JOIN [Table3] AS t3 ON [t2].[c2] = [t3].[c3]");
        }

        [Fact]
        public void ShouldReturnLeftJoinsStatement()
        {
            FlepperQueryBuilder
                .Select()
                .From("Table1").As("t1")
                .LeftJoin("Table2").As("t2")
                .On("t1", "c1").EqualTo("t2", "c1")
                .LeftJoin("Table3").As("t3")
                .On("t2", "c2").EqualTo("t3", "c3")
                .Build()
                .Trim()
                .Should()
                .Be("SELECT * FROM [Table1] AS t1 LEFT JOIN [Table2] AS t2 ON [t1].[c1] = [t2].[c1] LEFT JOIN [Table3] AS t3 ON [t2].[c2] = [t3].[c3]");
        }
    }
}