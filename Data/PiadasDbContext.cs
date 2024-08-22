using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Piadas.Models;

namespace Piadas.Data
{
    public class PiadasDbContext : DbContext
    {
        public PiadasDbContext (DbContextOptions<PiadasDbContext> options)
            : base(options)
        {
        }

        public DbSet<Piadas.Models.piadas> piadas { get; set; } = default!;
    }
}
