using System.Threading.Tasks;
using Nexus.Server.Model;
using Nexus.Server.Repositories;
using Xunit;

// ReSharper disable ConvertToUsingDeclaration

namespace Nexus.Test
{
    public class PersonalDetailsRepositoryTests
    {
        [Fact]
        public async Task TestGetByIdAsyncIdInvalid()
        {
            // Arrange
            var options = TestUtilities.BuildTestDbOptions();

            PersonalDetails result;

            await using (var context = new NexusContext(options))
            {
                context.Database.EnsureCreated();

                TestUtilities.SeedTestDb(context);

                var repository = new PersonalDetailsRepository(context);

                Assert.Single(context.PersonalDetails);

                // Act
                result = await repository.GetByIdAsync(2);

                context.Database.EnsureDeleted();
            }

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public async Task TestGetByIdAsyncIdValid()
        {
            // Arrange
            var options = TestUtilities.BuildTestDbOptions();

            PersonalDetails result;

            await using (var context = new NexusContext(options))
            {
                context.Database.EnsureCreated();

                TestUtilities.SeedTestDb(context);

                var repository = new PersonalDetailsRepository(context);

                Assert.Single(context.PersonalDetails);

                // Act
                result = await repository.GetByIdAsync(1);

                context.Database.EnsureDeleted();
            }

            // Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<PersonalDetails>(result);
            Assert.Equal("Jon", result.FirstName);
        }
    }
}