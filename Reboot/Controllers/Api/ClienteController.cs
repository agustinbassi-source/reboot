using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reboot.Business;
using Reboot.Business.Interface;
using Reboot.Models;

namespace Reboot.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteBusiness xxxxxxxxx;

 

        public void CrearCliente(Cliente cliente)
        {
            xxxxxxxxx.CrearCliente(cliente);
        }

        public void EliminarCliente(int id)
        {
            xxxxxxxxx.EliminarCliente(id);
        }

        public ClienteController()
        {
            xxxxxxxxx = new ClienteBusiness2();
            xxxxxxxxx = new ClienteBusiness(null);
        }

    }
}
