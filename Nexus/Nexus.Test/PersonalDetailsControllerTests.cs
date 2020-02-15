using System.Threading.Tasks;
using Nexus.Server.Controllers;
using Nexus.Server.Repositories;
using Nexus.Server.Services;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using Nexus.Server.Models;

// ReSharper disable ConvertToUsingDeclaration

namespace Nexus.Test
{
    public class PersonalDetailsControllerTests
    {
        [Fact]
        public async Task TestGetIdNull()
        {
            // Arrange
            var options = TestUtilities.BuildTestDbOptions();

            IActionResult result;

            await using (var context = new NexusContext(options))
            {
                var repositoryWrapper = new RepositoryWrapper(context);

                var service = new PersonalDetailsService(repositoryWrapper);

                var controller = new PersonalDetailsController(service);

                // Act
                result = await controller.Get(null);
            }

            // Assert
            var objectResult = Assert.IsAssignableFrom<BadRequestObjectResult>(result);
            Assert.Equal("The 'id' parameter cannot be null. Please try again with a valid parameter.",
                objectResult.Value);
        }

        [Fact]
        public async Task TestGetIdInvalid()
        {
            // Arrange
            var options = TestUtilities.BuildTestDbOptions();

            IActionResult result;

            await using (var context = new NexusContext(options))
            {
                context.Database.EnsureCreated();

                TestUtilities.SeedTestDb(context);

                var repositoryWrapper = new RepositoryWrapper(context);

                var service = new PersonalDetailsService(repositoryWrapper);

                var controller = new PersonalDetailsController(service);

                // Act
                result = await controller.Get(2);

                context.Database.EnsureDeleted();
            }

            // Assert
            Assert.IsAssignableFrom<NotFoundResult>(result);
        }

        [Fact]
        public async Task TestGetIdValid()
        {
            // Arrange
            var options = TestUtilities.BuildTestDbOptions();

            IActionResult result;

            await using (var context = new NexusContext(options))
            {
                context.Database.EnsureCreated();

                TestUtilities.SeedTestDb(context);

                var repositoryWrapper = new RepositoryWrapper(context);

                var service = new PersonalDetailsService(repositoryWrapper);

                var controller = new PersonalDetailsController(service);

                // Act
                result = await controller.Get(1);

                context.Database.EnsureDeleted();
            }

            // Assert
            var objectResult = Assert.IsAssignableFrom<OkObjectResult>(result);
            var entity = Assert.IsAssignableFrom<PersonalDetails>(objectResult.Value);
            Assert.Equal("Jon", entity.FirstName);
        }
    }
}