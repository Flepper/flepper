using Flepper.QueryBuilder;
using FluentAssertions;
using Xunit;

namespace Flepper.Tests.Unit.QueryBuilder.Commands
{
    [Collection("CommandTests")]
    public class WhereFilterTests
    {
        [Fact]
        public void ShouldContainsWhereInStatement()
        {
            FlepperQueryBuilder.Select()
                .From("user").Where("name")
                .Build()
                .Trim()
                .Should()
                .Contain("WHERE");
        }

        [Fact]
        public void ShouldContainsWhereWithComparisonOperatos()
        {
            var queryResult = FlepperQueryBuilder.Select()
                .From("user")
                .Where("name")
                .EqualTo("gustavo")
                .BuildWithParameters();


            queryResult
                .Query
                .Trim()
                .Should()
                .Contain("WHERE [name] = @p0");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal("gustavo", parameters.@p0);
        }

        [Fact]
        public void ShouldContainsWhereWithLogicalOperator()
        {
            var queryResult = FlepperQueryBuilder.Select()
                .From("user")
                .Where("name")
                .EqualTo("gustavo")
                .And("age")
                .BuildWithParameters();


            queryResult
                .Query
                .Trim()
                .Should()
                .Contain("WHERE [name] = @p0 AND [age]");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal("gustavo", parameters.@p0);
        }

        [Fact]
        public void ShouldContainsWhereWithLogicalOperatorWithComparisonOperators()
        {
            var queryResult = FlepperQueryBuilder.Select()
                .From("project")
                .Where("name").EqualTo("flepper")
                .And("age").GreaterThan(1)
                .Or("age").EqualTo(5)
                .And("csharpverson").GreaterThanOrEqualTo(7)
                .And("highcomplexmethods").LessThan(10)
                .And("highlocmethods").LessThanOrEqualTo(30)
                .And("repositoryhostedon").EqualTo("github")
                .And("active").NotEqualTo(false)
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("SELECT * FROM [project] WHERE [name] = @p0 " +
                    "AND [age] > @p1 " +
                    "OR [age] = @p2 " +
                    "AND [csharpverson] >= @p3 " +
                    "AND [highcomplexmethods] < @p4 " +
                    "AND [highlocmethods] <= @p5 " +
                    "AND [repositoryhostedon] = @p6 " +
                    "AND [active] <> @p7");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal("flepper", parameters.@p0);
            Assert.Equal(1, parameters.@p1);
            Assert.Equal(5, parameters.@p2);
            Assert.Equal(7, parameters.@p3);
            Assert.Equal(10, parameters.@p4);
            Assert.Equal(30, parameters.@p5);
            Assert.Equal("github", parameters.@p6);
            Assert.Equal(false, parameters.@p7);
        }

        [Fact]
        public void ShoulContainWhereWithNotEqual()
        {
            var queryResult = FlepperQueryBuilder.Select()
                .From("table")
                .Where("field").NotEqualTo("value")
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Contain("WHERE [field] <> @p0");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal("value", parameters.@p0);
        }

        [Fact]
        public void ShoulContainWhereWithGreaterThan()
        {
            var queryResult = FlepperQueryBuilder.Select()
                .From("table")
                .Where("field").GreaterThan(1)
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Contain("WHERE [field] > @p0");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal(1, parameters.@p0);
        }

        [Fact]
        public void ShoulContainWhereWithLessThan()
        {
            var queryResult = FlepperQueryBuilder.Select()
                .From("table")
                .Where("field").LessThan(1)
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Contain("WHERE [field] < @p0");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal(1, parameters.@p0);
        }

        [Fact]
        public void ShoulContainWhereWithGreaterThanOrEqualTo()
        {
            var queryResult = FlepperQueryBuilder.Select()
                .From("table")
                .Where("field").GreaterThanOrEqualTo(1)
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Contain("WHERE [field] >= @p0");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal(1, parameters.@p0);
        }

        [Fact]
        public void ShoulContainWhereWithLessThanOrEqualTo()
        {
            var queryResult = FlepperQueryBuilder.Select()
                .From("table")
                .Where("field").LessThanOrEqualTo(1)
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Contain("WHERE [field] <= @p0");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal(1, parameters.@p0);
        }

        [Fact]
        public void ShoulContainWhereWithNotEqualTo()
        {
            var queryResult = FlepperQueryBuilder.Select()
                .From("table")
                .Where("field").NotEqualTo(1)
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Contain("WHERE [field] <> @p0");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal(1, parameters.@p0);
        }

        [Fact]
        public void ShoulContainWhereWithEqualToNull()
        {
            FlepperQueryBuilder.Select()
                .From("table")
                .Where("field").EqualTo<object>(null)
                .Build()
                .Trim()
                .Should()
                .Contain("WHERE [field] IS NULL");
        }

        [Fact]
        public void ShoulContainWhereWithNotEqualToNull()
        {
            FlepperQueryBuilder.Select()
                .From("table")
                .Where("field").NotEqualTo<object>(null)
                .Build()
                .Trim()
                .Should()
                .Contain("WHERE [field] IS NOT NULL");
        }

        [Fact]
        public void ShoulContainLikeContains()
        {
            FlepperQueryBuilder.Select()
                .From("table")
                .Where("field").Contains("abc")
                .Build()
                .Trim()
                .Should()
                .Contain("LIKE");
        }

        [Fact]
        public void ShoulContainLikeStartsWith()
        {
            FlepperQueryBuilder.Select()
                .From("table")
                .Where("field").StartsWith("abc")
                .Build()
                .Trim()
                .Should()
                .Contain("LIKE");
        }

        [Fact]
        public void ShoulContainLikeEndsWith()
        {
            FlepperQueryBuilder.Select()
                .From("table")
                .Where("field").EndsWith("abc")
                .Build()
                .Trim()
                .Should()
                .Contain("LIKE");
        }

        [Fact]
        public void ShoulContainLikeContainsAndStartsWithAndEndsWith()
        {
            var result = FlepperQueryBuilder.Select()
                .From("table")
                .Where("field1").Contains("abc")
                .And("field2").StartsWith("abc")
                .And("field3").EndsWith("abc")
                .Build()
                .Trim()
                .Should();

            result.Contain("@p0");
            result.Contain("@p1");
            result.Contain("@p2");

            result.Contain("[field1]");
            result.Contain("[field2]");
            result.Contain("[field3]");

            result.Be("SELECT * FROM [table] WHERE [field1] LIKE @p0  AND [field2] LIKE @p1  AND [field3] LIKE @p2");
        }
    }
}
