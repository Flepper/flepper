using Flepper.QueryBuilder;
using Flepper.QueryBuilder.DapperExtensions;
using Flepper.Tests.Integration.Infra.Fixture;
using FluentAssertions;
using System;
using Xunit;

namespace Flepper.Tests.Integration.QueryBuilder
{
    [Collection("IntegrationTests")]
    public class SoftDeleteTests :IDisposable, IClassFixture<DatabaseFixture>
    {
        private readonly DatabaseFixture databaseFixture;
        public SoftDeleteTests(DatabaseFixture databaseFixture)
        {
            AdvancedSettings.EnableSoftDelete<User>(dto => dto.Active);
            AdvancedSettings.EnableSoftDelete<DTOTest2>(() => "Active");

            this.databaseFixture = databaseFixture;
        }
        [Fact]
        public void ShouldCreateSoftDeleteStatementCorrect()
        {
            using (var connection = databaseFixture.Connection)
            {
                connection.Open();

                var row = connection.SoftDelete<DTOTest2>("User")
                 .Where("Id").EqualTo(1)
                 .Execute();

                row.Should().Be(1);
            }
        }


        [Fact]
        public void ShouldCreateSoftDeleteCommandWithoutSpecifyTableName()
        {

            using (var connection = databaseFixture.Connection)
            {
                connection.Open();

                var row = connection.SoftDelete<User>()
                .Where("Id").EqualTo(2)
                 .Execute();

                row.Should().Be(1);
            }

        }

        [Fact]
        public void ShouldCreateSoftDeleteCommandWithColumnDefinedByString()
        {
            using (var connection = databaseFixture.Connection)
            {
                connection.Open();

                var row = connection.SoftDelete<DTOTest2>("User")
                .Where("Id").EqualTo(3)
                 .Execute();

                row.Should().Be(1);
            }

        }

        public void Dispose() => AdvancedSettings.ResetSoftDeleteConfiguration();

        public class User
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
