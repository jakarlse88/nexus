using System.Threading.Tasks;
using Nexus.Server.Model;
using Nexus.Server.Repositories;
using Nexus.Server.Services;
using Xunit;

namespace Nexus.Test
{
    public class PersonalDetailsServiceTests
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

                var repositoryWrapper = new RepositoryWrapper(context);

                var service = new PersonalDetailsService(repositoryWrapper);
                
                // Act
                result = await service.GetByIdAsync(2);

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

                var repositoryWrapper = new RepositoryWrapper(context);

                var service = new PersonalDetailsService(repositoryWrapper);
                
                // Act
                result = await service.GetByIdAsync(1);

                context.Database.EnsureDeleted();
            }
            
            // Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<PersonalDetails>(result);
            Assert.Equal("Jon", result.FirstName);
        }
    }
}