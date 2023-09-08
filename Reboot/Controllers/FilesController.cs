using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reboot.Models;
using System;

namespace Reboot.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FilesController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }


        [HttpPost]
        public async Task<IActionResult> SavePostImageAsync(IFormFile Image)
        {
            string directorio = Path.Combine(_webHostEnvironment.WebRootPath, "imagenes");

            // Asegurémonos de que el directorio exista, si no, créalo.
            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }

            if (Image != null && Image.Length > 0)
            {
                string fileName = Path.GetFileName(Image.FileName);
                string filePath = Path.Combine(directorio, fileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await Image.CopyToAsync(fileStream);
                }

                // En este punto, la imagen se ha guardado en el directorio especificado.
            }

            return Ok();


        }
    }
}
