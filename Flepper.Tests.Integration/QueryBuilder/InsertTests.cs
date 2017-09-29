using Flepper.Tests.Integration.Infra.Fixture;
using Xunit;
using Flepper.QueryBuilder;
using Flepper.QueryBuilder.DapperExtensions;
using FluentAssertions;

namespace Flepper.Tests.Integration
{
    public class InsertTests : IClassFixture<DatabaseFixture>
    {
        private readonly DatabaseFixture databaseFixture;

        public InsertTests(DatabaseFixture databaseFixture)
        {
            this.databaseFixture = databaseFixture;
        }

        [Fact]
        public void ShouldExecuteInsertProfile()
        {
            using (var connection = databaseFixture.Connection)
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
            using (var connection = databaseFixture.Connection)
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
    }
}
