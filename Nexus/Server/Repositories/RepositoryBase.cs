﻿using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Nexus.Server.Models;

namespace Nexus.Server.Repositories
{
    /// <summary>
    /// Base repository class from which the separate repository classes
    /// derive functionality.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class RepositoryBase<T> : IRepositoryBase<T> where T : EntityBase
    {
        private readonly NexusContext _context;

        protected RepositoryBase(NexusContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Asynchronously retrieves an entity by id. If no entity
        /// matches the id, the result will be null. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<T> GetByIdAsync(int id)
        {
            var result =
                await _context
                    .Set<T>()
                    .Where(t => 
                        t.Id == id)
                    .FirstOrDefaultAsync();

            return result;
        }
    }
}