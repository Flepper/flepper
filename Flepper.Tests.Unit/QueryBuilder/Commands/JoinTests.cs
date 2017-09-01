using Flepper.Core.QueryBuilder.Commands;
using Flepper.Core.QueryBuilder.Commands.Extensions;
using Flepper.Core.QueryBuilder.Join.Extensions;
using Flepper.Core.QueryBuilder.Join.Operators.Intersection.Extensions;
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
                .From("Table1")
                .InnerJoin("Table2");

            selectCommand
                 .Query
                 .Trim()
                 .Should()
                 .Contain("INNER JOIN [Table2]");
        }

        [Fact]
        public void ShouldReturnInnerJoinWithOnEqualStatement()
        {
            var selectCommand = new SelectCommand();

            selectCommand
                .Select()
                .From("Table1")
                .InnerJoin("Table2")
                .On("column1")
                .Equal("column2");

            selectCommand
                 .Query
                 .Trim()
                 .Should()
                 .Contain("INNER JOIN [Table2] ON [column1] = [column2]");
        }

        [Fact]
        public void ShouldReturnInnerJoinWithOnNotEqualStatement()
        {
            var selectCommand = new SelectCommand();

            selectCommand
                .Select()
                .From("Table1")
                .InnerJoin("Table2")
                .On("column1")
                .NotEqual("column2");

            selectCommand
                 .Query
                 .Trim()
                 .Should()
                 .Contain("INNER JOIN [Table2] ON [column1] <> [column2]");
        }
    }
}
