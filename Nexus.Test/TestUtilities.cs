using System;
using Microsoft.EntityFrameworkCore;
using Nexus.Server.Model;

namespace Nexus.Test
{
    public static class TestUtilities
    {
        internal static DbContextOptions<NexusContext> BuildTestDbOptions() 
        {
            return new DbContextOptionsBuilder<NexusContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
        }
    }
}