﻿using Flepper.QueryBuilder;
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
            using (var connection = databaseFixture.Connection)
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
            using (var connection = databaseFixture.Connection)
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
            using (var connection = databaseFixture.Connection)
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
            using (var connection = databaseFixture.Connection)
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
            using (var connection = databaseFixture.Connection)
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
            using (var connection = databaseFixture.Connection)
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
            using (var connection = databaseFixture.Connection)
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
            using (var connection = databaseFixture.Connection)
            {
                var profiles = connection.Select()
                    .From("User").As("U")
                    .InnerJoin("Profile").As("P")
                    .On("U", "ProfileId").EqualTo("P", "Id")
                    .Query();

                profiles.Should().NotBeEmpty();
            }
        }
    }

    public class Profile
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
