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

        public DbSet<Reboot.Models.Pedido> Pedido { get; set; } = default!;

        public DbSet<Reboot.Models.DetalleDelPedido> DetalleDelPedido { get; set; } = default!;
        public DbSet<Reboot.Models.Categoria> Categoria { get; set; } = default!;
        public DbSet<Reboot.Models.SubCategoria> SubCategoria { get; set; } = default!;

        public DbSet<Reboot.Models.PedidoDeInformacion> PedidoDeInformacion { get; set; } = default!;
        public DbSet<Reboot.Models.Empresa> Empresa { get; set; } = default!;
        public DbSet<Reboot.Models.Postulante> Postulante { get; set; } = default!;
    }
}
