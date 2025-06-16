using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using CRUD.Interface;
using CRUD.Model;


namespace CRUD.API.Controllers
{
    [Authorize] // Requer autenticação para todos os endpoints por padrão
    [ApiController]
    [Route("api/[controller]")] // Rota será: api/usuario
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _service;


        // Injeção de dependência do serviço
        public UsuarioController(IUsuarioService service)
        {
            _service = service;
        }


        /// <summary>
        /// Lista todos os usuários
        /// </summary>
        /// <returns>Lista de usuários</returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var usuarios = await _service.ListarAsync();
                return Ok(usuarios);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao listar usuários: {ex.Message}");
            }
        }


        /// <summary>
        /// Insere um novo usuário
        /// </summary>
        /// <param name="usuario">Objeto do tipo Usuario</param>
        /// <returns>ID do novo usuário</returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Usuario usuario)
        {
            if (usuario == null)
                return BadRequest("Usuário inválido.");

            try
            {
                var novoId = await _service.InserirAsync(usuario);
                return Ok(novoId);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao inserir usuário: {ex.Message}");
            }
        }


        /// <summary>
        /// Atualiza um usuário existente
        /// </summary>
        /// <param name="id">ID informado na URL</param>
        /// <param name="usuario">Objeto com os dados atualizados</param>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] Usuario usuario)
        {
            if (usuario == null)
                return BadRequest("Dados inválidos.");

            if (id != usuario.UsuarioId)
                return BadRequest("O ID da URL não confere com o ID do objeto.");

            try
            {
                await _service.AtualizarAsync(usuario);
                return NoContent(); // 204 - sucesso sem conteúdo
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao atualizar usuário: {ex.Message}");
            }
        }


        /// <summary>
        /// Deleta um usuário pelo ID
        /// </summary>
        /// <param name="id">ID do usuário a ser removido</param>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
                return BadRequest("ID inválido.");

            try
            {
                await _service.DeletarAsync(id);
                return Ok($"Usuário {id} removido com sucesso.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao deletar usuário: {ex.Message}");
            }
        }


    }
}

