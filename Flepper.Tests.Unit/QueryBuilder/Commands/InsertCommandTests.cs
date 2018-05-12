using Flepper.QueryBuilder;
using FluentAssertions;
using Xunit;

namespace Flepper.Tests.Unit.QueryBuilder.Commands
{
    [Collection("CommandTests")]
    public class InsertCommandTests
    {
        [Fact]
        public void ShouldCreateInsertStatementWithTable()
        {
            FlepperQueryBuilder.Insert().Into("Test")
                .Build()
                .Trim()
                .Should()
                .Be("INSERT INTO [Test]");
        }

        [Fact]
        public void ShouldCreateInsertStatementWithColumns()
        {
            FlepperQueryBuilder
                .Insert().Into("Test")
                .Columns("column1", "column2")
                .Build()
                .Trim()
                .Should()
                .Be("INSERT INTO [Test] ([column1],[column2] )");
        }

        [Fact]
        public void ShouldCreateInsertStatementWithColumnsArray()
        {
            FlepperQueryBuilder
                .Insert().Into("Test")
                .Columns(new[] { "column1", "column2" })
                .Build()
                .Trim()
                .Should()
                .Be("INSERT INTO [Test] ([column1],[column2] )");
        }

        [Fact]
        public void ShouldCreateInsertStatementWithValuesToColumns()
        {
            var queryResult = FlepperQueryBuilder
                .Insert().Into("Test")
                .Columns("column1", "column2")
                .Values("value1", 2)
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("INSERT INTO [Test] ([column1],[column2] ) VALUES (@p0, @p1)");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal("value1", parameters.@p0);
            Assert.Equal(2, parameters.@p1);
        }

        [Fact]
        public void ShouldCreateInsertStatementWithValues()
        {
            var queryResult = FlepperQueryBuilder
                .Insert().Into("Test")
                .Values("value1", 2)
                .BuildWithParameters();

            queryResult.Query
                .Trim()
                .Should()
                .Be("INSERT INTO [Test] VALUES (@p0, @p1)");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal("value1", parameters.@p0);
            Assert.Equal(2, parameters.@p1);
        }

        [Fact]
        public void ShouldCreateInsertStatementWithValuesToColumnsAndWithScopeIdentity()
        {
            var queryResult = FlepperQueryBuilder
                .Insert().Into("Test")
                .Columns("column1", "column2")
                .Values("value1", 100)
                .WithScopeIdentity()
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("INSERT INTO [Test] ([column1],[column2] ) VALUES (@p0, @p1);SELECT scope_identity();");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal("value1", parameters.@p0);
            Assert.Equal(100, parameters.@p1);

        }

        [Fact]
        public void ShouldCreateInsertStatementWithValuesAndWithScopeIdentity()
        {
            var queryResult = FlepperQueryBuilder
                .Insert().Into("Test")
                .Values("value1", 200)
                .WithScopeIdentity()
                .BuildWithParameters();

            queryResult.Query
                .Trim()
                .Should()
                .Be("INSERT INTO [Test] VALUES (@p0, @p1);SELECT scope_identity();");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal("value1", parameters.@p0);
            Assert.Equal(200, parameters.@p1);
        }

        [Fact]
        public void ShouldCreateInsertStatementWithValuesAndNullValueToColumns()
        {
            var queryResult = FlepperQueryBuilder
                .Insert().Into("Test")
                .Columns("column1", "column2", "column3")
                .Values("value1", FlepperQueryBuilder.NullValueString(), FlepperQueryBuilder.NullValue<System.DateTime>())
                .BuildWithParameters();

            queryResult
                .Query
                .Trim()
                .Should()
                .Be("INSERT INTO [Test] ([column1],[column2],[column3] ) VALUES (@p0, @p1, @p2)");

            dynamic parameters = queryResult.Parameters;

            Assert.Equal("value1", parameters.@p0);
            Assert.Equal(null, parameters.@p1);
            Assert.Equal(null, parameters.@p2);
        }
        /**/
        [Fact]
        public void ShouldCreateInsertStatementWithSelectQueryBuilder()
        {
            var querySelect = FlepperQueryBuilder
                .Select(new string[] { "column1", "column2" })
                .From("Test2");

            var queryResult = FlepperQueryBuilder
                .Insert()
                .Into("Test")
                .Columns(new string[] { "column1", "column2" })
                .Values(_ => querySelect)
                .BuildWithParameters();

            Assert.Equal("INSERT INTO [Test] ([column1],[column2] ) SELECT [column1],[column2] FROM [Test2] ", queryResult.Query);
        }

        [Fact]
        public void ShouldCreateInsertStatementWithSelectQueryBuilderWithWhere()
        {
            var querySelect = FlepperQueryBuilder
                .Select(new string[] { "column1", "column2" })
                .From("Test2")
                .Where("Id").EqualTo(1);

            var queryResult = FlepperQueryBuilder
                .Insert()
                .Into("Test")
                .Columns(new string[] { "column1", "column2" })                
                .Values(_ => querySelect)                
                .BuildWithParameters();

            Assert.Equal("INSERT INTO [Test] ([column1],[column2] ) SELECT [column1],[column2] FROM [Test2] WHERE [Id] = @p0 ", queryResult.Query);

            dynamic parameters = queryResult.Parameters;
            Assert.Equal(1, parameters.@p0);
        }

        [Fact]
        public void ShouldCreateInsertStatementWithSelectQueryBuilderWithWhereAndIn()
        {
            var querySelect = FlepperQueryBuilder
                .Select(new string[] { "column1", "column2" })
                .From("Test2")
                .Where("Id").EqualTo(1)
                .And("Status").In("A", "B");

            var queryResult = FlepperQueryBuilder
                .Insert()
                .Into("Test")
                .Columns(new string[] { "column1", "column2" })
                .Values(_ => querySelect)
                .BuildWithParameters();

            Assert.Equal("INSERT INTO [Test] ([column1],[column2] ) SELECT [column1],[column2] FROM [Test2] WHERE [Id] = @p0 AND [Status] IN(@p1,@p2) ", queryResult.Query);

            dynamic parameters = queryResult.Parameters;
            Assert.Equal(1, parameters.@p0);
            Assert.Equal("A", parameters.@p1);
            Assert.Equal("B", parameters.@p2);
        }

        [Fact]
        public void ShouldCreateInsertStatementWithSelectQueryBuilderWithWhereAndNotIn()
        {
            var querySelect = FlepperQueryBuilder
                .Select(new string[] { "column1", "column2" })
                .From("Test2")
                .Where("Id").EqualTo(1)
                .And("Status").NotIn("A", "B");

            var queryResult = FlepperQueryBuilder
                .Insert()
                .Into("Test")
                .Columns(new string[] { "column1", "column2" })
                .Values(_ => querySelect)
                .BuildWithParameters();

            Assert.Equal("INSERT INTO [Test] ([column1],[column2] ) SELECT [column1],[column2] FROM [Test2] WHERE [Id] = @p0 AND [Status] NOT IN(@p1,@p2) ", queryResult.Query);

            dynamic parameters = queryResult.Parameters;
            Assert.Equal(1, parameters.@p0);
            Assert.Equal("A", parameters.@p1);
            Assert.Equal("B", parameters.@p2);
        }


        [Fact]
        public void ShouldCreateInsertStatementWithSelectQueryBuilderWithWhereAndInSelect()
        {
            var querySelect = FlepperQueryBuilder
                .Select(new string[] { "column1", "column2" })
                .From("Test2")
                .Where("Id").EqualTo(1)
                .And("Status").In(_ => FlepperQueryBuilder.Select("Status").From("Test3").Where("Id").EqualTo(2));
                
            var queryResult = FlepperQueryBuilder
                .Insert()
                .Into("Test")
                .Columns(new string[] { "column1", "column2" })
                .Values(_ => querySelect)
                .BuildWithParameters();

            Assert.Equal("INSERT INTO [Test] ([column1],[column2] ) SELECT [column1],[column2] FROM [Test2] WHERE [Id] = @p0 AND [Status] IN(SELECT [Status] FROM [Test3] WHERE [Id] = @p1 ) ", queryResult.Query);

            dynamic parameters = queryResult.Parameters;
            Assert.Equal(1, parameters.@p0);
            Assert.Equal(2, parameters.@p1);
        }

        [Fact]
        public void ShouldCreateInsertStatementWithSelectQueryBuilderWithWhereAndNotInSelect()
        {
            var querySelect = FlepperQueryBuilder
                .Select(new string[] { "column1", "column2" })
                .From("Test2")
                .Where("Id").EqualTo(1)
                .And("Status").NotIn(_ => FlepperQueryBuilder.Select("Status").From("Test3").Where("Id").EqualTo(2));

            var queryResult = FlepperQueryBuilder
                .Insert()
                .Into("Test")
                .Columns(new string[] { "column1", "column2" })
                .Values(_ => querySelect)
                .BuildWithParameters();

            Assert.Equal("INSERT INTO [Test] ([column1],[column2] ) SELECT [column1],[column2] FROM [Test2] WHERE [Id] = @p0 AND [Status] NOT IN(SELECT [Status] FROM [Test3] WHERE [Id] = @p1 ) ", queryResult.Query);

            dynamic parameters = queryResult.Parameters;
            Assert.Equal(1, parameters.@p0);
            Assert.Equal(2, parameters.@p1);
        }

        [Fact]
        public void ShouldCreateSelectStatementWithWhereAndInWithWhereIQueryCommand()
        {
            var querySelect0 = FlepperQueryBuilder.Select("Status").From("Test").Where("Id").EqualTo(100);
            var queryResult = FlepperQueryBuilder
                .Select()
                .From("TestSuper")
                .Where("Id").In(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)
                .And("Id").In(_ => querySelect0) // IQueryCommand
                .And("Id").In(11, 12, 13, 14, 15, 16, 17, 18, 19, 20)
                .BuildWithParameters();

            Assert.Equal("SELECT * FROM [TestSuper] WHERE [Id] IN(@p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9) AND [Id] IN(SELECT [Status] FROM [Test] WHERE [Id] = @p10 ) AND [Id] IN(@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18,@p19,@p20) ", queryResult.Query);

            dynamic parameters = queryResult.Parameters;
            Assert.Equal(1, parameters.@p0);
            Assert.Equal(2, parameters.@p1);
            Assert.Equal(3, parameters.@p2);
            Assert.Equal(4, parameters.@p3);
            Assert.Equal(5, parameters.@p4);
            Assert.Equal(6, parameters.@p5);
            Assert.Equal(7, parameters.@p6);
            Assert.Equal(8, parameters.@p7);
            Assert.Equal(9, parameters.@p8);
            Assert.Equal(10, parameters.@p9);
            Assert.Equal(100, parameters.@p10);
            Assert.Equal(11, parameters.@p11);
            Assert.Equal(12, parameters.@p12);
            Assert.Equal(13, parameters.@p13);
            Assert.Equal(14, parameters.@p14);
            Assert.Equal(15, parameters.@p15);
            Assert.Equal(16, parameters.@p16);
            Assert.Equal(17, parameters.@p17);
            Assert.Equal(18, parameters.@p18);
            Assert.Equal(19, parameters.@p19);
            Assert.Equal(20, parameters.@p20);
        }

        [Fact]
        public void ShouldCreateSelectStatementWithWhereAndSelectQueryBuilder()
        {
            var querySelect0 = FlepperQueryBuilder.Select("Status").From("Test1").Where("Id").EqualTo(10);
            var querySelect1 = FlepperQueryBuilder.Select("Status").From("Test1").Where("Id").EqualTo(20);
            var querySelect2 = FlepperQueryBuilder.Select("Status").From("Test1").Where("Id").EqualTo(30);

            var queryResult = FlepperQueryBuilder
                .Select()
                .From("TestSuper")
                .Where("Id").NotEqualTo(1)
                .And("Status").In(_ => querySelect0)
                .And("Id").NotEqualTo(2)
                .And("Status").In(_ => querySelect1)
                .And("Id").NotEqualTo(3)
                .And("Status").In(_ => querySelect2)
                .BuildWithParameters();

            Assert.Equal("SELECT * FROM [TestSuper] WHERE [Id] <> @p0 AND [Status] IN(SELECT [Status] FROM [Test1] WHERE [Id] = @p1 ) AND [Id] <> @p2 AND [Status] IN(SELECT [Status] FROM [Test1] WHERE [Id] = @p3 ) AND [Id] <> @p4 AND [Status] IN(SELECT [Status] FROM [Test1] WHERE [Id] = @p5 ) ", queryResult.Query);

            dynamic parameters = queryResult.Parameters;
            Assert.Equal(1, parameters.@p0);
            Assert.Equal(10, parameters.@p1);
            Assert.Equal(2, parameters.@p2);
            Assert.Equal(20, parameters.@p3);
            Assert.Equal(3, parameters.@p4);
            Assert.Equal(30, parameters.@p5);
        }
    }
}
