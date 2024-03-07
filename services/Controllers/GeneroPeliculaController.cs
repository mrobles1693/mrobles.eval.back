using entity;
using Microsoft.AspNetCore.Mvc;
using repository.Interfaces;

namespace services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneroPeliculaController : ControllerBase
    {
        public readonly IGeneroPeliculaRepository repository;

        public GeneroPeliculaController(IGeneroPeliculaRepository _repository)
        {
            repository = _repository;
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<ApiResponse<List<GeneroPeliculaEntity>>>> GetListGeneroPelicula()
        {
            ApiResponse<List<GeneroPeliculaEntity>> response = new ApiResponse<List<GeneroPeliculaEntity>>();

            try
            {
                var result = await repository.GetListGeneroPelicula();

                response.success = true;
                response.data = (List<GeneroPeliculaEntity>)result;
                return StatusCode(200, response);
            }
            catch (Exception ex)
            {
                response.success = false;
                response.errMsj = ex.Message;
                return StatusCode(500, response);
            }
        }
    }
}
