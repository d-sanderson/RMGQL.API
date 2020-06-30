using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RMGQL.API.Data;
using RMGQL.API.Data.Entities;

namespace RMGQL.API.Repositories
{
    public class QuoteRepository
    {
        private readonly QuoteDbContext _dbContext;

        public QuoteRepository(QuoteDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<Quote>> GetAll()
        {
            return _dbContext.Quotes.ToListAsync();
        }
    }
}
