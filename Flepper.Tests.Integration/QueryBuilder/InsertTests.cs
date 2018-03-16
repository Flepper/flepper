using Flepper.QueryBuilder;
using Flepper.QueryBuilder.DapperExtensions;
using Flepper.Tests.Integration.Infra.Fixture;
using FluentAssertions;
using Xunit;

namespace Flepper.Tests.Integration.QueryBuilder
{
    [Collection("IntegrationTests")]
    public class InsertTests : IClassFixture<DatabaseFixture>
    {
        private readonly DatabaseFixture _databaseFixture;

        public InsertTests(DatabaseFixture databaseFixture)
        {
            _databaseFixture = databaseFixture;
        }

        [Fact]
        public void ShouldExecuteInsertProfile()
        {
            using (var connection = _databaseFixture.Connection)
            {
                connection.Open();
                var rows = connection.Insert()
                    .Into("Profile")
                    .Columns("Name")
                    .Values("buzz")
                    .Execute();

                rows.Should()
                    .BeGreaterThan(0);
            }
        }


        [Fact]
        public async void ShouldExecuteInsertProfileAsync()
        {
            using (var connection = _databaseFixture.Connection)
            {
                connection.Open();
                var rows = await connection.Insert()
                    .Into("Profile")
                    .Columns("Name")
                    .Values("feed")
                    .ExecuteAsync();

                rows.Should()
                    .BeGreaterThan(0);
            }
        }

        [Fact]
        public async void ShouldExecuteInsertNullValuesAsync()
        {
            using (var connection = _databaseFixture.Connection)
            {
                connection.Open();
                var rows = await connection.Insert()
                    .Into("User")
                    .Columns("Name", "Email", "Nickname", "ProfileId")
                    .Values("buzz", "feezz@flepper.com", FlepperQueryBuilder.NullValueString(), 1)
                    .ExecuteAsync();

                rows.Should()
                    .BeGreaterThan(0);
            }
        }
    }
}
