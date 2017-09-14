using Flepper.QueryBuilder;
using FluentAssertions;
using Xunit;

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
                .Contain("INNER JOIN [Table2] t2");
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
                .Contain("INNER JOIN [Table2] t2 ON t2.[column1] = t1.[column2]");
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
                .Contain("INNER JOIN [Table2] t2 ON t2.[column1] <> t1.[column2]");
        }

        [Fact]
        public void ShouldReturnInnerJoinWithWhereStatement()
        {
            var queryResult = FlepperQueryBuilder.Select()
                .From("Table1").As("t1")
                .InnerJoin("Table2").As("t2")
                .On("t2", "column1")
                .NotEqualTo("t1", "column2")
                .Where("t1", "name").EqualTo("table")
                .BuildWithParameters();

            queryResult.Query
                .Trim()
                .Should()
                .Contain("INNER JOIN [Table2] t2 ON t2.[column1] <> t1.[column2] WHERE t1.[name] = @p0");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal("table", parameters.@p0);
        }
    }
}