using System;
using System.Linq;
using Flepper.QueryBuilder;
using Flepper.QueryBuilder.Utils;
using FluentAssertions;
using Xunit;
using static Flepper.QueryBuilder.FlepperQueryFunction;

namespace Flepper.Tests.Unit.QueryBuilder.Commands
{
    [Collection("CommandTests")]
    public class SelectCommandTests : IDisposable
    {
        public SelectCommandTests()
            => Cache.DtoProperties.Clear();

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
        public void ShouldCreateSelectStatementWithSpecificColumnsWithAliases()
        {
            FlepperQueryBuilder.Select("Id", As("Name", "MyName"), "Birthday")
                .From("user")
                .Build()
                .Trim()
                .Should()
                .Be("SELECT [Id],[Name] AS MyName,[Birthday] FROM [user]");
        }

        [Fact]
        public void ShouldThrowAnExceptionWhenSomeColumnNameIsNull()
        {
            var argumentNullException = Assert.Throws<ArgumentNullException>(() => FlepperQueryBuilder.Select("Id", "Name as MyName", null)
                .From("user")
                .Build());

            argumentNullException.Message.Should().Be($"All columns names should not be null{Environment.NewLine}Parameter name: columns");
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
        public void ShouldCreateSelectWithColumnsOfType()
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
        public void ShouldThrowNoSupportedExcetionWhenConstructionNonAnonymousObject()
        {
            var notSupportedException = Assert.Throws<NotSupportedException>(() =>
            {
                FlepperQueryBuilder
                    .Select<UserDto>(user => new OtherUser(user.Name))
                    .From("user")
                    .Build();
            });

            notSupportedException.Message.Should().Be("The given expression is not supported, you must pass a expression that return an anonymous object, something like that: () => new { dto.Property1, dto.Property2 }");
            Cache.DtoProperties.Should().BeEmpty();
        }

        [Fact]
        public void ShouldCreateSelectWithColumnsOfAnonymousType()
        {
            FlepperQueryBuilder
                .Select<UserDto>(user => new { user.Id, user.Name })
                .From("user")
                .Build()
                .Trim()
                .Should()
                .Be("SELECT [Id],[Name] FROM [user]");

            Cache.DtoProperties.Should().HaveCount(1);
            Cache.DtoProperties.First().Value.Select(x => x.ToString()).Should().BeEquivalentTo("[Id]", "[Name]");
        }

        [Fact]
        public void ShouldCreateSelectWithColumnsOfPropertyExpression()
        {
            FlepperQueryBuilder
                .Select<UserDto>(user => user.Name)
                .From("user")
                .Build()
                .Trim()
                .Should()
                .Be("SELECT [Name] FROM [user]");

            Cache.DtoProperties.Should().HaveCount(1);
            Cache.DtoProperties.First().Value.Select(x => x.ToString()).Should().BeEquivalentTo("[Name]");
        }

        [Fact]
        public void ShouldCreateOnlyOneEntryInCacheWhenUsingPropertyExpression()
        {
            FlepperQueryBuilder
                .Select<UserDto>(user => user.Name)
                .From("user")
                .Build();

            FlepperQueryBuilder
                .Select<UserDto>(user => user.Name)
                .From("user")
                .Build();

            Cache.DtoProperties.Should().HaveCount(1);
            Cache.DtoProperties.First().Value.Select(x => x.ToString()).Should().BeEquivalentTo("[Name]");
        }

        [Fact]
        public void ShouldThrowNoSupportedExcetionWhenPassingOtherKindOfExpression()
        {
            var notSupportedException = Assert.Throws<NotSupportedException>(() =>
            {
                FlepperQueryBuilder
                    .Select<UserDto>(user => user.Id.ToString())
                    .From("user")
                    .Build();
            });

            notSupportedException.Message.Should().Be("The given expression is not supported, you must pass a expression that return an anonymou object, something like that: () => new { dto.Property1, dto.Property2 }");
            Cache.DtoProperties.Should().BeEmpty();
        }

        [Fact]
        public void ShouldThrowNoSupportedExcetionWhenPassingPropertyExpressionThatDoesNotReturnAStrirgOrValueType()
        {
            var notSupportedException = Assert.Throws<NotSupportedException>(() =>
            {
                FlepperQueryBuilder
                    .Select<OtherUser>(user => user.OtherProperty)
                    .From("user")
                    .Build();
            });

            notSupportedException.Message.Should().Be("Only strings or value types expression are supported");
            Cache.DtoProperties.Should().BeEmpty();
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

        [Fact]
        public void ShouldCreateSelectTop1StatementForAllColumns()
        {
            FlepperQueryBuilder.Select().Top().From("user")
                .Build()
                .Trim()
                .Should()
                .Be("SELECT TOP 1 * FROM [user]");
        }

        [Fact]
        public void ShouldCreteSelectTop1WithWhereCondition()
        {
            var queryResult = FlepperQueryBuilder.Select("Id", "Name", "Birthday")
                .Top()
                .From("user")
                .Where("Name").EqualTo("Nicolas")
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("SELECT TOP 1 [Id],[Name],[Birthday] FROM [user] WHERE [Name] = @p0");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal("Nicolas", parameters.@p0);
        }

        [Fact]
        public void ShouldCreateSelectTop5StatementForAllColumns()
        {
            FlepperQueryBuilder.Select().Top(5).From("user")
                .Build()
                .Trim()
                .Should()
                .Be("SELECT TOP 5 * FROM [user]");
        }

        [Fact]
        public void ShouldCreteSelectTop5WithWhereCondition()
        {
            var queryResult = FlepperQueryBuilder.Select("Id", "Name", "Birthday")
                .Top(5)
                .From("user")
                .Where("Name").EqualTo("Nicolas")
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("SELECT TOP 5 [Id],[Name],[Birthday] FROM [user] WHERE [Name] = @p0");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal("Nicolas", parameters.@p0);
        }

        [Fact]
        public void ShouldCreateSelectStatementWithGroupBy()
        {
            var queryResult = FlepperQueryBuilder
                .Select("Name", "Age")
                .From("User")
                .GroupBy("Age")
                .BuildWithParameters()
                .Query
                .Trim()
                .Should()
                .Be("SELECT [Name],[Age] FROM [User] GROUP BY [Age]"); ;
        }

        [Fact]
        public void ShouldCreateSelectStatementWithGroupByAfterWhere()
        {
            var queryResult = FlepperQueryBuilder
                .Select("Name", "Age")
                .From("User")
                .Where("column1").EqualTo(1)
                .GroupBy("Age")
                .BuildWithParameters()
                .Query
                .Trim()
                .Should()
                .Be("SELECT [Name],[Age] FROM [User] WHERE [column1] = @p0 GROUP BY [Age]"); ;
        }

        [Fact]
        public void ShouldCreateSelectWithTableAliasOnSelectedColumns()
        {
            FlepperQueryBuilder.
                Select(AsFrom("t1", "Name"))
                .From("Table1").As("t1")
                .Build()
                .Trim()
                .Should()
                .Be("SELECT [t1].[Name] FROM [Table1] AS t1");
        }

        [Fact]
        public void ShouldCreateSelectStatementWithCount()
        {
            var queryResult = FlepperQueryBuilder
                .Select(Count("column2", "cl2"))
                .From("User")
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("SELECT COUNT([column2]) AS cl2 FROM [User]");
        }

        [Fact]
        public void ShouldCreateSelectStatementWithCountAndMultipleColumns()
        {
            var queryResult = FlepperQueryBuilder
                .Select("column1", Count("column2", "cl2"), "column3")
                .From("User")
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("SELECT [column1],COUNT([column2]) AS cl2,[column3] FROM [User]");
        }

        [Fact]
        public void ShouldCreateSelectStatementWithCountAndMultipleColumnsWithAlias()
        {
            var queryResult = FlepperQueryBuilder
                .Select("column1", Count("column2", "cl2"), As("column3", "cl3"))
                .From("User")
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("SELECT [column1],COUNT([column2]) AS cl2,[column3] AS cl3 FROM [User]");
        }

        [Fact]
        public void ShouldCreateSelectStatementWithMinAndMultipleColumns()
        {
            var queryResult = FlepperQueryBuilder
                .Select("column1", Min("column2", "cl2"), "column3")
                .From("User")
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("SELECT [column1],MIN([column2]) AS cl2,[column3] FROM [User]");
        }

        [Fact]
        public void ShouldCreateSelectStatementWithMinAndMultipleColumnsWithAlias()
        {
            var queryResult = FlepperQueryBuilder
                .Select("column1", Min("column2", "cl2"), As("column3", "cl3"))
                .From("User")
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("SELECT [column1],MIN([column2]) AS cl2,[column3] AS cl3 FROM [User]");
        }


        [Fact]
        public void ShouldCreateSelectStatementWithMin()
        {
            var queryResult = FlepperQueryBuilder
                .Select(Min("column2", "cl2"))
                .From("User")
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("SELECT MIN([column2]) AS cl2 FROM [User]");
        }

        [Fact]
        public void ShouldCreateSelectStatementWithMinAlias()
        {
            var queryResult = FlepperQueryBuilder
                .Select(
                    Min(AsFrom("usr", "column2"), "cl2"),
                    AsFrom("usr", "column3"))
                .From("User")
                .As("usr")
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("SELECT MIN([usr].[column2]) AS cl2,[usr].[column3] FROM [User] AS usr");
        }

        [Fact]
        public void ShouldCreateSelectStatementWithAsFunction()
        {
            var queryResult = FlepperQueryBuilder
                .Select(
                    As("column2", "cl2"))
                .From("User")
                .As("usr")
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("SELECT [column2] AS cl2 FROM [User] AS usr");
        }

        public void ShouldCreateSelectStatementWithAsAndMinAndAsFromFunction()
        {
            var queryResult = FlepperQueryBuilder
                .Select(
                    As("column2", "cl2"),
                    AsFrom("usr", Min("column3", "cl3")),
                    AsFrom("usr", "column4")
                    )
                .From("User")
                .As("usr")
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("SELECT [column2] AS cl2, MIN([usr].[column3]) AS cl3, [usr].[column4] FROM [User] AS usr");

        }


        [Fact]
        public void ShouldCreateQueryWithJoinAndWhereFilter()
        {
            var queryResult = FlepperQueryBuilder
                .Select()
                .From("Table").As("A")
                .InnerJoin("Table").As("B")
                .Where("A", "Id").EqualTo(0)
                .And("B", "Id").EqualTo(1)
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("SELECT * FROM [Table] AS A INNER JOIN [Table] AS B WHERE [A].[Id] = @p0 AND [B].[Id] = @p1");
        }

        [Fact]
        public void ShouldCreateSelectStatementWithMaxAndMultipleColumns()
        {
            var queryResult = FlepperQueryBuilder
                .Select("column1", Max("column2", "cl2"), "column3")
                .From("User")
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("SELECT [column1],MAX([column2]) AS cl2,[column3] FROM [User]");
        }

        [Fact]
        public void ShouldCreateSelectStatementWithMaxsAndMultipleColumns()
        {
            var queryResult = FlepperQueryBuilder
                .Select("column1",
                    Max("column2", "cl2"),
                    Max("column3", "cl3"))
                .From("User")
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("SELECT [column1],MAX([column2]) AS cl2,MAX([column3]) AS cl3 FROM [User]");
        }

        [Fact]
        public void ShouldCreateSelectDistinctStatementWithSpecificColumns()
        {
            FlepperQueryBuilder.SelectWithDistinct("Id", "Name", "Birthday")
                .From("user")
                .Build()
                .Trim()
                .Should()
                .Be("SELECT DISTINCT [Id],[Name],[Birthday] FROM [user]");
        }

        public void Dispose()
            => Cache.DtoProperties.Clear();
    }

    public class UserDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }
    }

    public class OtherUser
    {
        public OtherUser()
        {

        }

        public OtherUser(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public OtherUser OtherProperty { get; set; }
    }
}