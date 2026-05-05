using Blazorise;
using CanineCompetition.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CanineCompetition
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<DurationEntry> DurationEntries { get; set; }

        public async Task<List<DurationEntry>> GetAlltriesAsync()
        {
            return await DurationEntries
                .OrderBy(i => i.Id)
                .ToListAsync();
        }
    }

}
