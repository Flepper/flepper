using Flepper.QueryBuilder;
using FluentAssertions;
using System;
using Xunit;

namespace Flepper.Tests.Unit.QueryBuilder.Commands
{
    [Collection("CommandTests")]
    public class OrderByCommandTests
    {
        [Fact]
        public void ShouldCreateSelectStatementWithOrderBy()
        {
            FlepperQueryBuilder.Select<UserDto>(user => new { user.Id, user.Name })
               .From("user")
               .OrderBy("Name")
               .Build()
               .Trim()
               .Should()
               .Be("SELECT [Id],[Name],[Birthday] FROM [user] ORDER BY [Name]");

            FlepperQueryBuilder
               .Select<UserDto>(user => new { user.Id, user.Name })
               .From("user")
               .Build()
               .Trim()
               .Should()
               .Be("SELECT [Id],[Name] FROM [user]");
        }
        
        [Fact]
        public void ShouldCreateSelectStatementWithOrderByDesc()
        {
            FlepperQueryBuilder.Select("Id", "Name", "Birthday")
               .From("user")
               .OrderByDescending("Birthday")
               .Build()
               .Trim()
               .Should()
               .Be("SELECT [Id],[Name],[Birthday] FROM [user] ORDER BY [Birthday] DESC");
        }
       
        [Fact]
        public void ShouldCreateSelectBirthdayWithWhereAndOrderBy()
        {
            var queryResult = FlepperQueryBuilder.Select("Id", "Name", "Birthday")
                .From("user")
                .Where("Name").EqualTo("Fabio")
                .OrderBy("Name")
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("SELECT [Id],[Name],[Birthday] FROM [user] WHERE [Name] = @p0 ORDER BY [Name]");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal("Fabio", parameters.@p0);
        }

        [Fact]
        public void ShouldCreateSelectBirthdayWithWhereAndMultipleOrderBy()
        {
            var queryResult = FlepperQueryBuilder.Select("Id", "Name", "Birthday")
                .From("user")
                .Where("Age").LessThan(29)
                .OrderBy("Name")
                .OrderBy("Birthday")
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("SELECT [Id],[Name],[Birthday] FROM [user] WHERE [Age] < @p0 ORDER BY [Name],[Birthday]");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal(29, parameters.@p0);
        }

        [Fact]
        public void ShouldCreateSelectBirthdayWithWhereAndMultipleOrderByAscDesc()
        {
            var queryResult = FlepperQueryBuilder.Select("Id", "Name", "Birthday")
                .From("user")
                .Where("Age").LessThan(29)
                .OrderByDescending("Birthday")
                .OrderBy("Name")                
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("SELECT [Id],[Name],[Birthday] FROM [user] WHERE [Age] < @p0 ORDER BY [Birthday] DESC,[Name]");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal(29, parameters.@p0);
        }

        [Fact]
        public void ShouldCreateSelectWithWhereAndInnerJoinOrderByStatement()
        {
            var queryResult = FlepperQueryBuilder.Select("Id", "Name", "Age")
                .From("user").As("t1")
                .InnerJoin("address").As("t2").On("t2", "column1").EqualTo("t1", "column2")
                .Where("Age").EqualTo(29)
                .OrderBy("t1", "Name")
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("SELECT [Id],[Name],[Age] FROM [user] t1 INNER JOIN [address] t2 ON t2.[column1] = t1.[column2] WHERE [Age] = @p0 ORDER BY t1.[Name]");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal(29, parameters.@p0);
        }      

        [Fact]
        public void ShouldCreateSelectWithWhereAndInnerJoinOrderByDescStatement()
        {
            var queryResult = FlepperQueryBuilder.Select("Id", "Name", "Age")
               .From("user").As("t1")
               .InnerJoin("address").As("t2").On("t2", "column1").EqualTo("t1", "column2")
               .Where("Age").EqualTo(29)
               .OrderByDescending("t1", "Name")
               .OrderByDescending("t1", "Age")
               .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("SELECT [Id],[Name],[Age] FROM [user] t1 INNER JOIN [address] t2 ON t2.[column1] = t1.[column2] WHERE [Age] = @p0 ORDER BY t1.[Name],t1.[Age] DESC");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal(29, parameters.@p0);
        }

        [Fact]
        public void ShouldCreateSelectStatementWithMultipleOrderByButItShouldOnlyBeDescending()
        {
            FlepperQueryBuilder.Select("Id", "Name", "Birthday")
               .From("user")
               .OrderBy("Name")
               .OrderByDescending("Birthday")
               .Build()
               .Trim()
               .Should()
               .Be("SELECT [Id],[Name],[Birthday] FROM [user] ORDER BY [Name],[Birthday] DESC");
        }
    }    
}