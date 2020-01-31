using System.Threading.Tasks;
using Nexus.Server.Model;
using Nexus.Server.Repositories;
using Xunit;
// ReSharper disable ConvertToUsingDeclaration

namespace Nexus.Test
{
    public class PersonalDetailsRepositoryTests
    {
        private static void SeedTestDb(NexusContext context)
        {
            context.PersonalDetails.Add(
                new PersonalDetails
                {
                    Id = 1,
                    FirstName = "Jon",
                    LastName = "Karlsen",
                    Biography = "Once upon a time",
                    JobTitle = "Back-End Web Dev"
                });

            context.SaveChanges();
        }
        
        [Fact]
        public async Task TestGetByIdAsyncIdInvalid()
        {
            // Arrange
            var options = TestUtilities.BuildTestDbOptions();

            PersonalDetails result;
            
            await using (var context = new NexusContext(options))
            {
                context.Database.EnsureCreated();

                SeedTestDb(context);

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

                SeedTestDb(context);

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