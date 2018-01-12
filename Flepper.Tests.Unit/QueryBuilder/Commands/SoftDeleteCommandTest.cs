using Flepper.QueryBuilder;
using FluentAssertions;
using System;
using Xunit;

namespace Flepper.Tests.Unit.QueryBuilder.Commands
{
    public class SoftDeleteCommandTest : IDisposable
    {
        public SoftDeleteCommandTest()
        {
            AdvancedSettings.EnableSoftDelete<DTOTest>(dto => dto.Active);
            AdvancedSettings.EnableSoftDelete<DTOTest2>(() => "Deleted");
        }
        [Fact]
        public void ShouldCreateSoftDeleteStatementCorrect()
        {
            var query = FlepperQueryBuilder
                .SoftDelete<DTOTest>("test")
                .Where("column1").EqualTo(2)
                .BuildWithParameters();

            query
                .Query
                .Trim()
                .Should().Be("UPDATE [test] SET [Active] = @p0 WHERE [column1] = @p1");
        }


        [Fact]
        public void ShouldCreateSoftDeleteCommandWithoutSpecifyTableName()
        {
            var query = FlepperQueryBuilder
                .SoftDelete<DTOTest>()
                .Where("column1").EqualTo(2)
                .BuildWithParameters();

            query
                .Query
                .Trim()
                .Should().Be("UPDATE [DTOTest] SET [Active] = @p0 WHERE [column1] = @p1");
        }

        [Fact]
        public void ShouldCreateSoftDeleteCommandWithColumnDefinedByString()
        {
            var query = FlepperQueryBuilder
                .SoftDelete<DTOTest2>()
                .Where("column1").EqualTo(2)
                .BuildWithParameters();

            query
                .Query
                .Trim()
                .Should().Be("UPDATE [DTOTest2] SET [Deleted] = @p0 WHERE [column1] = @p1");
        }

        public void Dispose()
        {
            AdvancedSettings.ResetSoftDeleteConfiguration();
        }

        public class DTOTest
        {
            public int Active { get; set; }
            public string Name { get; set; }
        }

        public class DTOTest2
        {
            public int Deleted { get; set; }
            public string Name { get; set; }
        }
    }
}
