using Chapter.Interfaces;
using Chapter.Models;
using Chapter.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Chapter.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _iusuarioRepository;

        public UsuarioController(IUsuarioRepository iusuarioRepository)
        {
            _iusuarioRepository = iusuarioRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(_iusuarioRepository.Listar());
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            try
            {
                Usuario usuarioEncontrado = _iusuarioRepository.BuscarPorId(id);
                if(usuarioEncontrado == null)
                {
                    return NotFound();
                }
                return Ok(usuarioEncontrado);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
