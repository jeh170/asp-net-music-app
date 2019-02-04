using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AspCoreStarterApp.Models
{
    public class AspCoreStarterAppContext : DbContext
    {
        public AspCoreStarterAppContext (DbContextOptions<AspCoreStarterAppContext> options)
            : base(options)
        {
        }

        public DbSet<AspCoreStarterApp.Models.Album> Album { get; set; }
    }
}
