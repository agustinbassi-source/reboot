using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reboot.Business;
using Reboot.Data;
using Reboot.Models;
using Reboot.Repository;

namespace Reboot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly PedidoBusiness _pedidoBusiness;

        public PedidoController(RebootContext context)
        {
            _pedidoBusiness = new PedidoBusiness(context);
        }

        [HttpGet(Name = "ObtenerPedido")]
        public IActionResult ObtenerPedido(int idPedido)
        {
            Pedido pedido = _pedidoBusiness.ObtenerPedido(idPedido);

            return Ok(pedido);
        }
    }
}
