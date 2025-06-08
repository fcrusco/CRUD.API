using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using CRUD.Model;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginModel login)
    {
        if (login.Usuario == "Admin" && login.Senha == "Admin")
        {
            var token = GerarTokenJWT(login.Usuario);
            return Ok(new { token });
        }

        return Unauthorized("Usuário ou senha inválidos.");
    }

    private string GerarTokenJWT(string usuario)
    {
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("minha-chave-secreta-@#$%wertdfgsdfgsdfg"));
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
