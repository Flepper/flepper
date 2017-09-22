﻿using Flepper.QueryBuilder;
using FluentAssertions;
using Xunit;

namespace Flepper.Tests.Unit.QueryBuilder.Commands
{
    [Collection("CommandTests")]
    public class OrderByCommandTests
    {
        [Fact]
        public void ShouldCreateSelectStatementWithOrderBy()
        {
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
            FlepperQueryBuilder
                .Select()
                .Top(1)
                .From("dbo", "user")
                .OrderByDescending("Birthday")
                .Build()
                .Trim()
                .Should()
                .Be("SELECT TOP 1 * FROM [dbo].[user] ORDER BY [Birthday] DESC");
        }

        [Fact]
        public void ShouldCreateSelectBirthdayWithWhereAndOrderBy()
        {
            var queryResult = FlepperQueryBuilder.Select<UserDto>(user => new { user.Id, user.Name, user.Birthday })
                .From("user")
                .Where("Name").EqualTo("Fabio")
                .OrderBy("Birthday")
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("SELECT [Id],[Name],[Birthday] FROM [user] WHERE [Name] = @p0 ORDER BY [Birthday]");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal("Fabio", parameters.@p0);
        }

        [Fact]
        public void ShouldCreateSelectBirthdayWithWhereAndMultipleOrderBy()
        {
            var queryResult = FlepperQueryBuilder.Select<UserDto>(user => new { user.Id, user.Name, user.Birthday })
               .From("user").As("t1")
               .Where("Name").EqualTo("Fabio")
               .OrderBy("Name")
               .ThenBy("t1", "Birthday")
               .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("SELECT [Id],[Name],[Birthday] FROM [user] t1 WHERE [Name] = @p0 ORDER BY [Name], [t1].[Birthday]");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal("Fabio", parameters.@p0);
        }

        [Fact]
        public void ShouldCreateSelectBirthdayWithWhereAndMultipleOrderByAscDesc()
        {
            var queryResult = FlepperQueryBuilder.Select<UserDto>(user => new { user.Id, user.Name, user.Birthday })
                .From("user")
                .Where("Name").EqualTo("Fabio")
                .OrderByDescending("Birthday")
                .ThenBy("Name")                
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("SELECT [Id],[Name],[Birthday] FROM [user] WHERE [Name] = @p0 ORDER BY [Birthday] DESC, [Name]");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal("Fabio", parameters.@p0);
        }

        [Fact]
        public void ShouldCreateSelectWithWhereAndInnerJoinOrderByStatement()
        {
            var queryResult = FlepperQueryBuilder.Select<UserDto>(user => new { user.Id, user.Name })
                .From("user").As("t1")
                .InnerJoin("address").As("t2").On("t2", "column1").EqualTo("t1", "column2")
                .Where("Name").EqualTo("Fabio")
                .OrderBy("t1", "Name")
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("SELECT [Id],[Name] FROM [user] t1 INNER JOIN [address] t2 ON t2.[column1] = t1.[column2] WHERE [Name] = @p0 ORDER BY [t1].[Name]");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal("Fabio", parameters.@p0);
        }

        [Fact]
        public void ShouldCreateSelectWithWhereAndInnerJoinOrderByDescStatement()
        {
            var queryResult = FlepperQueryBuilder.Select<UserDto>(user => new { user.Id, user.Name, user.Birthday })
               .From("user").As("t1")
               .InnerJoin("address").As("t2").On("t2", "column1").EqualTo("t1", "column2")
               .Where("Name").EqualTo("Fabio")
               .OrderByDescending("t1", "Name")
               .ThenByDescending("t1", "Birthday")
               .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("SELECT [Id],[Name],[Birthday] FROM [user] t1 INNER JOIN [address] t2 ON t2.[column1] = t1.[column2] WHERE [Name] = @p0 ORDER BY [t1].[Name] DESC, [t1].[Birthday] DESC");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal("Fabio", parameters.@p0);
        }

        [Fact]
        public void ShouldCreateSelectStatementWithMultipleOrderByButItShouldOnlyBeDescending()
        {
            FlepperQueryBuilder.Select<UserDto>(user => new { user.Id, user.Name, user.Birthday })
               .From("user")
               .OrderBy("Name")
               .ThenByDescending("Birthday")
               .Build()
               .Trim()
               .Should()
               .Be("SELECT [Id],[Name],[Birthday] FROM [user] ORDER BY [Name], [Birthday] DESC");
        }
    }    
}
