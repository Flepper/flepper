using Flepper.QueryBuilder;
using Flepper.QueryBuilder.DapperExtensions;
using Flepper.Tests.Integration.Infra.Fixture;
using FluentAssertions;
using Xunit;
using static Flepper.QueryBuilder.FlepperQueryFunction;

namespace Flepper.Tests.Integration.QueryBuilder
{
    [Collection("IntegrationTests")]
    public class SelectTests : IClassFixture<DatabaseFixture>
    {
        private readonly DatabaseFixture _databaseFixture;

        public SelectTests(DatabaseFixture databaseFixture)
        {
            _databaseFixture = databaseFixture;
        }

        [Fact]
        public void ShouldSelectAllProfiles()
        {
            using (var connection = _databaseFixture.Connection)
            {
                var profiles = connection.Select("Id", "Name")
                    .From("Profile")
                    .Query<Profile>();

                profiles.Should()
                    .NotBeEmpty();
            }
        }

        [Fact]
        public async void ShouldSelectAllProfilesAsync()
        {
            using (var connection = _databaseFixture.Connection)
            {
                var profiles = await connection.Select("Id", "Name")
                    .From("Profile")
                    .QueryAsync<Profile>();

                profiles.Should()
                    .NotBeEmpty();
            }
        }

        [Fact]
        public void ShouldSelectProfileWithWhere()
        {
            using (var connection = _databaseFixture.Connection)
            {
                var profile = connection.Select("Id", "Name")
                    .From("Profile")
                    .Where("Id").EqualTo(1)
                    .QueryFirstOrDefault<Profile>();

                profile.Should().NotBeNull();
            }
        }

        [Fact]
        public void ShouldSelectProfileWithCount()
        {
            using (var connection = _databaseFixture.Connection)
            {
                var profile = connection.Select(Count("Id", "Total"))
                    .From("Profile")
                    .QueryFirstOrDefault<int>();

                profile.Should().NotBe(0);
            }
        }


        [Fact]
        public void ShouldSelectProfileWithOrderBy()
        {
            using (var connection = _databaseFixture.Connection)
            {
                var profile = connection.Select("Name")
                    .From("Profile")
                    .OrderBy("Name")
                    .Query();

                profile.Should().NotBeEmpty();
            }
        }

        [Fact]
        public void ShouldSelectProfileWithMultiplesOrderBy()
        {
            using (var connection = _databaseFixture.Connection)
            {
                var profile = connection.Select("Id", "Name")
                    .From("Profile")
                    .OrderBy("Id")
                    .ThenBy("Name")
                    .Query();

                profile.Should().NotBeEmpty();
            }
        }

        [Fact]
        public void ShouldSelectProfileWithOrderByDescending()
        {
            using (var connection = _databaseFixture.Connection)
            {
                var profile = connection.Select("Name")
                    .From("Profile")
                    .OrderByDescending("Name")
                    .Query();

                profile.Should().NotBeEmpty();
            }
        }

        [Fact]
        public void ShouldSelectProfileWithMultiplesOrderByDescending()
        {
            using (var connection = _databaseFixture.Connection)
            {
                var profile = connection.Select("Id", "Name")
                    .From("Profile")
                    .OrderByDescending("Id")
                    .ThenByDescending("Name")
                    .Query();

                profile.Should().NotBeEmpty();
            }
        }


        [Fact]
        public void ShouldSelectUserWithProfile()
        {
            using (var connection = _databaseFixture.Connection)
            {
                var profiles = connection.Select()
                    .From("User").As("U")
                    .InnerJoin("Profile").As("P")
                    .On("U", "ProfileId").EqualTo("P", "Id")
                    .Query();

                profiles.Should().NotBeEmpty();
            }
        }

        [Fact]
        public void ShouldSelectUserWithWhereIn()
        {
            using (var connection = _databaseFixture.Connection)
            {
                var users = connection.Select()
                    .From("User")
                    .Where("Id").In(1, 2, 3)
                    .Query();

                users.Should().NotBeEmpty();
            }
        }

        [Fact]
        public void ShouldSelectUserWithWhereNotIn()
        {
            using (var connection = _databaseFixture.Connection)
            {
                var users = connection.Select()
                    .From("User")
                    .Where("Id").NotIn(1, 2, 3)
                    .Query();

                users.Should().BeNullOrEmpty();
            }
        }

        [Fact]
        public void ShouldSelectUserWithWhereInSelect()
        {
            using (var connection = _databaseFixture.Connection)
            {
                var users = connection.Select()
                    .From("User")
                    .Where("Id").In(_ => connection.Select("Id").From("Profile"))
                    .Query();

                users.Should().NotBeEmpty();
            }
        }

        [Fact]
        public void ShouldSelectUserWithWhereNotInSelect()
        {
            using (var connection = _databaseFixture.Connection)
            {
                var users = connection.Select()
                    .From("User")
                    .Where("Id").NotIn(_ => connection.Select("Id").From("Profile"))
                    .Query();

                users.Should().NotBeEmpty();
            }
        }
    }

    public class Profile
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
