﻿using Nexus.Server.Models;

namespace Nexus.Server.Repositories
{
    /// <summary>
    /// Wraps the separate repositories (which again inherit
    /// from RepositoryBase), for ease of organisation and use. 
    /// </summary>
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly NexusContext _context;

        private IPersonalDetailsRepository _personalDetailsRepository;
        
        public RepositoryWrapper(NexusContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves the wrapper's PersonalDetailsRepository,
        /// creating it if necessary.
        /// </summary>
        public IPersonalDetailsRepository PersonalDetails =>
            _personalDetailsRepository ??=
                new PersonalDetailsRepository(_context);
    }
}