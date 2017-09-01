using Flepper.Core.QueryBuilder;
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
                .InnerJoin("Table2").As("t2");

            FlepperQueryBuilder.Query
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
                .Equal("t1", "column2");

            FlepperQueryBuilder.Query
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
                .NotEqual("t1", "column2");

            FlepperQueryBuilder.Query
                 .Trim()
                 .Should()
                 .Contain("INNER JOIN [Table2] t2 ON t2.[column1] <> t1.[column2]");
        }

        [Fact]
        public void ShouldReturnInnerJoinWithWhereStatement()
        {
            FlepperQueryBuilder.Select()
                .From("Table1").As("t1")
                .InnerJoin("Table2").As("t2")
                .On("t2", "column1")
                .NotEqual("t1", "column2")
                .Where("t1", "name").Equal("table");

            FlepperQueryBuilder.Query
                .Trim()
                .Should()
                .Contain("INNER JOIN [Table2] t2 ON t2.[column1] <> t1.[column2] WHERE t1.[name] = 'table'");
        }
    }
}
