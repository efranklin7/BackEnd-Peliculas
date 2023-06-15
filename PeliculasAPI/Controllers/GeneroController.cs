using Microsoft.AspNetCore.Mvc;
using PeliculasAPI.Model;
using PeliculasAPI.Model.Repositorio;

namespace PeliculasAPI.Controllers
{
    [ApiController]
    [Route("api/generos")]
    public class GeneroController : ControllerBase
    {
        private readonly IRepositorio repositorio;

        public GeneroController(IRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }
        
        [HttpGet]
        public ActionResult<List<Genero>> get()
        {
            var x= repositorio.obtenerGeneros();
            return x;
        }
        [HttpGet("{id:int}")]
        public ActionResult<Genero> get(int id)
        {
            var x = repositorio.obtenerGenerosId(id);
            return x;
        }
        [HttpPost]
        public ActionResult<Genero> post(Genero genero)
        {
            return Ok();
        }

    }
}
 