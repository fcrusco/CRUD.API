using CRUD.Interface;
using CRUD.Model;
using CRUD.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CRUD.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _service;
        public UsuarioController(IUsuarioService service) => _service = service;


        //[HttpPost("login")]
        //public IActionResult Login([FromBody] LoginModel login)
        //{
        //    if (login.Usuario == "Admin" && login.Senha == "Admin")
        //    {
        //        var token = GerarTokenJWT(login.Usuario);
        //        return Ok(new { token });
        //    }

        //    return Unauthorized("Usuário ou senha inválidos.");
        //}


        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Get() => Ok(await _service.ListarAsync());



        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Post([FromBody] Usuario usuario) =>
            Ok(await _service.InserirAsync(usuario));



        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] Usuario usuario)
        {
            if (id != usuario.UsuarioId)
                return BadRequest("O ID da URL e do corpo não coincidem.");

            await _service.AtualizarAsync(usuario);
            return NoContent();
        }



        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeletarAsync(id);
            return Ok();
        }



        private string GerarTokenJWT(string usuario)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("MinhaChaveSuperSecreta@123"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
            new Claim(ClaimTypes.Name, usuario),
            new Claim(ClaimTypes.Role, "Admin")
        };

            var token = new JwtSecurityToken(
                issuer: "crud-api",
                audience: "crud-client",
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }

}
