using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Reboot.Models;

namespace Reboot.Data
{
    public class RebootContext : DbContext
    {
        public RebootContext (DbContextOptions<RebootContext> options)
            : base(options)
        {
        }

        public DbSet<Reboot.Models.ArticuloFerreteria> ArticuloFerreteria { get; set; } = default!;

        public DbSet<Reboot.Models.Cliente> Cliente { get; set; } = default!;
    }
}
