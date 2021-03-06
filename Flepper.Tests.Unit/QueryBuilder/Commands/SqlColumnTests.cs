﻿using System.Linq;
using FluentAssertions;
using Xunit;
using Flepper.QueryBuilder;
using static Flepper.QueryBuilder.FlepperQueryFunction;

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
        public void ShouldCreateColumnWithAlias()
        {
            var column = As("Column","C");

            column.ToString().Should().Be("[Column] AS C");
        }

        [Fact]
        public void ShouldCreateColumnWithTableAlias()
        {
            var column =  AsFrom("t1","Column");

            column.ToString().Should().Be("[t1].[Column]");
        }

        [Fact]
        public void ShouldCreateColumnWithAliasAndTableAlias()
        {
            var column = As(AsFrom("t1","Column"),"c");

            column.ToString().Should().Be("[t1].[Column] AS c");
        }

        [Fact]
        public void ShoudNotAddBracketsWhenColumnIsAsterisk()
        {
            var column = AsFrom("t1","*");

            column.ToString().Should().Be("[t1].*");
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
