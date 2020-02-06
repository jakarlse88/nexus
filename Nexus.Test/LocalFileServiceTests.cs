using System;
using System.IO;
using System.Threading.Tasks;
using Nexus.Server.Services;
using Xunit;

namespace Nexus.Test
{
    public class LocalFileServiceTests
    {
        [Fact]
        public async Task TestRetrieveLocalFileStreamFileNameInvalid()
        {
            // Arrange
            const string fileName = "invalid.pdf";

            var localFileService = new LocalFileService();
            
            // Act
            var result = 
               await  localFileService.RetrieveLocalFileStream(fileName);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public async Task TestRetrieveLocalFileStreamFileNameValid()
        {
            // Arrange
            const string fileName = "resume.pdf";

            var localFileService = new LocalFileService();
            
            // Act
            var result = 
                await  localFileService.RetrieveLocalFileStream(fileName);

            // Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<FileStream>(result);
        }

    }
}