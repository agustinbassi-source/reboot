using Reboot.Data;
using Reboot.Models;
using Reboot.Repository;

namespace Reboot.Business
{
    public class PedidoBusiness
    {
        private readonly PedidoRepository _pedidoRepository;

        public PedidoBusiness(RebootContext context)
        {
            _pedidoRepository = new PedidoRepository(context);
        }

        public Pedido ObtenerPedido(int idPedidoooo)
        {
            var elPedido = _pedidoRepository.ObtenerPedido(idPedidoooo);

            return elPedido;
        }

        public void EliminarDetalleDelPedido(int idDetalle)
        {
             _pedidoRepository.EliminarDetalleDelPedido(idDetalle);

           
        }
    }
}
