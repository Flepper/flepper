using System;
using Flepper.QueryBuilder;
using FluentAssertions;
using Xunit;

namespace Flepper.Tests.Unit.QueryBuilder.Commands
{
    [Collection("CommandTests")]
    public class SelectCommandTests
    {
        [Fact]
        public void ShouldCreateSelectStatementForAllColumns()
        {
            FlepperQueryBuilder.Select().From("user")
                .Build()
                .Trim()
                .Should()
                .Be("SELECT * FROM [user]");
        }

        [Fact]
        public void ShouldCreateSelectStatementWithSpecificColumns()
        {
            FlepperQueryBuilder.Select("Id", "Name", "Birthday")
                .From("user")
                .Build()
                .Trim()
                .Should()
                .Be("SELECT [Id],[Name],[Birthday] FROM [user]");
        }

        [Fact]
        public void ShouldCreteSelectWithWhereCondition()
        {
            var queryResult = FlepperQueryBuilder.Select("Id", "Name", "Birthday")
                .From("user")
                .Where("Name").EqualTo("Nicolas")
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("SELECT [Id],[Name],[Birthday] FROM [user] WHERE [Name] = @p0");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal("Nicolas", parameters.@p0);
        }

        [Fact]
        public void ShoudCreateSelectWithColumnsOfType()
        {
            FlepperQueryBuilder
                .Select<UserDto>()
                .From("user")
                .Build()
                .Trim()
                .Should()
                .Be("SELECT [Id],[Name],[Birthday] FROM [user]");
        }

        [Fact]
        public void ShouldCreateSelectStatementWithSchema()
        {
            FlepperQueryBuilder.Select()
                .From("dbo", "user")
                .Build()
                .Trim()
                .Should()
                .Be("SELECT * FROM [dbo].[user]");
        }
    }

    public class UserDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }
    }
}