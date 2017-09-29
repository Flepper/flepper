using Flepper.QueryBuilder;
using Flepper.QueryBuilder.DapperExtensions;
using Flepper.Tests.Integration.Infra.Fixture;
using FluentAssertions;
using Xunit;

namespace Flepper.Tests.Integration.QueryBuilder
{
    [Collection("IntegrationTests")]
    public class UpdateTests : IClassFixture<DatabaseFixture>
    {
        private readonly DatabaseFixture databaseFixture;

        public UpdateTests(DatabaseFixture databaseFixture)
        {
            this.databaseFixture = databaseFixture;
        }

        [Fact]
        public void ShouldUpdateProfile()
        {
            using (var connection = databaseFixture.Connection)
            {
                connection.Open();
                var row = connection.Update("Profile")
                    .Set("Name", "testUpdate")
                    .Where("Id").EqualTo(1)
                    .Execute();

                row.Should().BeGreaterThan(0);
            }
        }

        [Fact]
        public async void ShouldUpdateProfileAsync()
        {
            using (var connection = databaseFixture.Connection)
            {
                connection.Open();
                var row = await connection.Update("Profile")
                    .Set("Name", "testUpdateAsync")
                    .Where("Id").EqualTo(2)
                    .ExecuteAsync();

                row.Should().BeGreaterThan(0);
            }
        }
    }
}
