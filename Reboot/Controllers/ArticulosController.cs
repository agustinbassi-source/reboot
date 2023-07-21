using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reboot.Data;
using Reboot.Models;

namespace Reboot.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ArticulosController : ControllerBase
    {
        private readonly RebootContext _context;

        public ArticulosController(RebootContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "ObtenerArticulos")]
        public IActionResult ObtenerArticulos()
        {
            List<ArticuloFerreteria> listado = new List<ArticuloFerreteria>();

            listado = _context.ArticuloFerreteria.ToList();
             
            return Ok(listado);
        }

       
    }
}
