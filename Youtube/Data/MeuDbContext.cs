using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Youtube.Models;

namespace Youtube.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions<MeuDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<YoutubeResult> YoutubeResults { get; set; }
    }
}
