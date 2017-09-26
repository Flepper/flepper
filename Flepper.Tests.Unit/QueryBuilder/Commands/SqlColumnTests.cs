using System.Linq;
using Flepper.QueryBuilder.Base;
using FluentAssertions;
using Xunit;

namespace Flepper.Tests.Unit.QueryBuilder.Commands
{
    public class SqlColumnTests
    {
        [Fact]
        public void ShouldCreateRegularColumn()
        {
            var column = new SqlColumn("Column");

            column.ToString().Should().Be("[Column]");
        }

        [Fact]
        public void ShouldCreateRegularColumnWithAsUpperCamelCase()
        {
            var column = new SqlColumn("Column As cl");

            column.ToString().Should().Be("[Column] AS cl");
        }

        [Fact]
        public void ShouldCreateRegularColumnWithAsLowerCamelCase()
        {
            var column = new SqlColumn("Column as cl");

            column.ToString().Should().Be("[Column] AS cl");
        }

        [Fact]
        public void ShouldImplicitConvertStringToSqlColumn()
        {
            var actual = typeof(SqlColumn).GetMethods();

            actual
                .Select(m => new { name = m.Name, type = m.ReturnType.Name })
                .Should()
                .Contain(new { name = "op_Implicit", type = typeof(string).Name });
        }

        [Fact]
        public void ShouldImplicitConvertSqlColumnToString()
        {
            var actual = typeof(SqlColumn).GetMethods();

            actual
                .Select(m => new { name = m.Name, type = m.ReturnType.Name })
                .Should()
                .Contain(new { name = "op_Implicit", type = typeof(SqlColumn).Name });
        }
    }
}
