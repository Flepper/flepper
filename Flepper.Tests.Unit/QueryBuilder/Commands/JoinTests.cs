using Flepper.Core.QueryBuilder;
using Flepper.Core.QueryBuilder.Commands.Extensions;
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
            var selectCommand = new SelectCommand();

            selectCommand
                .Select()
                .From("Table1").As("t1")
                .InnerJoin("Table2").As("t2");

            selectCommand
                 .Query
                 .Trim()
                 .Should()
                 .Contain("INNER JOIN [Table2] t2");
        }

        [Fact]
        public void ShouldReturnInnerJoinWithOnEqualStatement()
        {
            var selectCommand = new SelectCommand();

            selectCommand
                .Select()
                .From("Table1").As("t1")
                .InnerJoin("Table2").As("t2")
                .On("t2", "column1")
                .Equal("t1","column2");

            selectCommand
                 .Query
                 .Trim()
                 .Should()
                 .Contain("INNER JOIN [Table2] t2 ON t2.[column1] = t1.[column2]");
        }

        [Fact]
        public void ShouldReturnInnerJoinWithOnNotEqualStatement()
        {
            var selectCommand = new SelectCommand();

            selectCommand
                .Select()
                .From("Table1").As("t1")
                .InnerJoin("Table2").As("t2")
                .On("t2", "column1")
                .NotEqual("t1", "column2");

            selectCommand
                 .Query
                 .Trim()
                 .Should()
                 .Contain("INNER JOIN [Table2] t2 ON t2.[column1] <> t1.[column2]");
        }

        [Fact]
        public void ShouldReturnInnerJoinWithWhereStatement()
        {
            var selectCommand = new SelectCommand();

            selectCommand
                .Select()
                .From("Table1").As("t1")
                .InnerJoin("Table2").As("t2")
                .On("t2", "column1")
                .NotEqual("t1", "column2")
                .Where("t1", "name").Equal("table");

            selectCommand
                .Query
                .Trim()
                .Should()
                .Contain("INNER JOIN [Table2] t2 ON t2.[column1] <> t1.[column2] WHERE t1.[name] = 'table'");
        }
    }
}
