using System.Collections.Generic;
using System.Linq;
using MovieMgr.Core.Contracts;
using MovieMgr.Core.Entities;

namespace MovieMgr.Persistence
{
    public class MovieRepository : IMovieRepository
    {
        private ApplicationDbContext _dbContext;

        public MovieRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int GetCount()
        {
            return _dbContext.Movies.Count();
        }
    }
}