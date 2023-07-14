using Reboot.Data;
using Reboot.Models;

namespace Reboot.Repository
{
    public class PedidoRepository
    {
        private readonly RebootContext _context;

        public PedidoRepository(RebootContext context)
        {
            _context = context;
        }

        public Pedido ObtenerPedido(int idDelPedido)
        {
            Pedido elPedido = _context
                .Pedido
                .Where(ddd => ddd.Id == idDelPedido)
                .FirstOrDefault();

            elPedido.DetalleDelPedido = _context.DetalleDelPedido
                .Where(dp => dp.IdDelPedido == idDelPedido)
                .ToList();

            elPedido.ClienteDelPedido = _context.Cliente
          .Where(cliente => cliente.Id == elPedido.ClienteId)
          .FirstOrDefault();
             
            return elPedido;
        }
    }
}
