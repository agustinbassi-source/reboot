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
    public class ClientesController : ControllerBase
    {
        private readonly ClienteBusiness _clienteBusiness;

        public ClientesController(RebootContext context)
        {
            _clienteBusiness = new ClienteBusiness(context);
        }

        [HttpPost(Name = "CrearCliente")]
        public IActionResult CrearClientes(Cliente elCLienteDelHtml)
        {
            // 1 - Crear clientes
            var idDelCLiente = _clienteBusiness.CrearCliente(elCLienteDelHtml);

            // 2 - Retornar ok
            return Ok(idDelCLiente);
        }

        [HttpGet(Name = "ObtenerClientes")]
        public IActionResult ObtenerClientes()
        {
            // 1 - Obtener clientes
            var clientes = _clienteBusiness.ObtenerClientes();

            // 2 - Retornar los clientes

            if (clientes.Count == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(clientes);
            }



        }
    }
}
