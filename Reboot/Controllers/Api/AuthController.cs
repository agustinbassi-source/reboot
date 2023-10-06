using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Reboot.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Reboot.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        [HttpPost]
        public async Task<ActionResult<AuthResponse>> AuthC(AuthRequest request)
        {
            // Verificamos credenciales con Identity
            //var user = await userManager.FindByNameAsync(request.Usuario);

            //if (user is null || !await userManager.CheckPasswordAsync(user, request.Password))
            //{
            //    return Results.Forbid();
            //}

            // var roles = await userManager.GetRolesAsync(user);

            if (request.Usuario != "juan" || request.Contraseña != "1234")
            {
                throw new Exception("usuario incorrecto");
            }

            // Generamos un token según los claims
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Sid, "123"),
                new Claim(ClaimTypes.Name, "juan"),
                new Claim(ClaimTypes.GivenName,"perez")
            };


            claims.Add(new Claim(ClaimTypes.Role, "superUser"));


            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("S3cr3t_K3y!.123_S3cr3t_K3y!.123"));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
            var tokenDescriptor = new JwtSecurityToken(
                issuer: "WebApiJwt.com",
                audience: "localhost",
                claims: claims,
                expires: DateTime.Now.AddMinutes(720),
                signingCredentials: credentials);

            var jwt = new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);

            return Ok(new AuthResponse
            {
                AccessToken = jwt
            });
        }

    }
}
