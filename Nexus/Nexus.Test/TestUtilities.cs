using System;
using Microsoft.EntityFrameworkCore;
using Nexus.Server.Models;

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

        public static void SeedTestDb(NexusContext context)
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
    }
}