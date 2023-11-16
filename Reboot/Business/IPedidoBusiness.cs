using Reboot.Models;

namespace Reboot.Business
{
    public interface IPedidoBusiness
    {
        void EliminarDetalleDelPedido(int idDetalle);
        Pedido ObtenerPedido(int idPedidoooo);
    }
}