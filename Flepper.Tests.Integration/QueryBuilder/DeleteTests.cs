using Flepper.QueryBuilder;
using Flepper.QueryBuilder.DapperExtensions;
using Flepper.Tests.Integration.Infra.Fixture;
using FluentAssertions;
using Xunit;

namespace Flepper.Tests.Integration.QueryBuilder
{
    [Collection("IntegrationTests")]
    public class DeleteTests : IClassFixture<DatabaseFixture>
    {
        private readonly DatabaseFixture databaseFixture;

        public DeleteTests(DatabaseFixture databaseFixture)
        {
            this.databaseFixture = databaseFixture;
        }

        [Fact]
        public void ShouldDeleteUser()
        {
            using (var connection = databaseFixture.Connection)
            {
                connection.Open();
                
                var row = connection.Delete().From("User")
                    .Where("Id").EqualTo(1)
                    .Execute();

                row.Should().BeGreaterThan(0);
            }
        }

        [Fact]
        public async void ShouldDeleteUserAsync()
        {
            using (var connection = databaseFixture.Connection)
            {
                connection.Open();
                var row = await connection.Delete().From("User")
                    .Where("Id").EqualTo(2)
                    .ExecuteAsync();

                row.Should().BeGreaterThan(0);
            }
        }
    }
}
