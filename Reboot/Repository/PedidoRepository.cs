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

        public Pedido ObtenerPedido(int id)
        {
            var elPedido = _context.Pedido.Where(pedido => pedido.Id == id).FirstOrDefault();

            return elPedido;
        }
    }
}
