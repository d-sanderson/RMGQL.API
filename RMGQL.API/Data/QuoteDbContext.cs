using Microsoft.EntityFrameworkCore;
using RMGQL.API.Data.Entities;


namespace RMGQL.API.Data
{
    public class QuoteDbContext : DbContext
    {

        public QuoteDbContext(DbContextOptions<QuoteDbContext> options) : base(options)
        {

        }
        public DbSet<Quote> Quotes { get; set; }
    }
}
