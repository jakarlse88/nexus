using Nexus.Server.Models;
using Nexus.Server.Repositories;
using Xunit;

namespace Nexus.Test
{
    public class RepositoryWrapperTests
    {
        [Fact]
        public void TestPersonalDetails()
        {
            // Arrange
            var options = TestUtilities.BuildTestDbOptions();

            IPersonalDetailsRepository repo;
            
            using (var context = new NexusContext(options))
            {
                var repoWrapper = new RepositoryWrapper(context);

                // Act
                repo = repoWrapper.PersonalDetails;
            }

            // Assert
            Assert.NotNull(repo);
            Assert.IsAssignableFrom<IPersonalDetailsRepository>(repo);
        }

    }
}