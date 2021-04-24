using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrelloDevTestAPI.Models
{
    public class HistoricalSearchContext : DbContext
    {
        public HistoricalSearchContext(DbContextOptions<HistoricalSearchContext> options) :base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<HistoricalSearch> History { get; set; }
    }
}
