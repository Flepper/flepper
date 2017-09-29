using Flepper.Tests.Integration.Infra.Fixture;
using Xunit;
using Flepper.QueryBuilder;
using Flepper.QueryBuilder.DapperExtensions;
using FluentAssertions;

namespace Flepper.Tests.Integration.QueryBuilder
{
    public class SelectTests : IClassFixture<DatabaseFixture>
    {
        private readonly DatabaseFixture databaseFixture;

        public SelectTests(DatabaseFixture databaseFixture)
        {
            this.databaseFixture = databaseFixture;
        }

        [Fact]
        public void ShouldSelectAllProfiles()
        {
            using (var connection = databaseFixture.Connection)
            {
                var profiles = connection.Select<Profile>(profile => new { profile.Id, profile.Name })
                    .From("Profile")
                    .Query<Profile>();

                profiles.Should()
                    .NotBeEmpty();
            }
        }
    }

    class Profile
    {
        public int Id { get; set; }
        public int Name { get; set; }
    }
}
