using entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using repository.Interfaces;

namespace services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculaController : ControllerBase
    {
        public readonly IPeliculaRepository repository;

        public PeliculaController(IPeliculaRepository _repository)
        {
            repository = _repository;
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<ApiResponse<PeliculaEntity>>> getPelicula(int nIdPelicula)
        {

            ApiResponse<PeliculaEntity> response = new ApiResponse<PeliculaEntity>();

            try
            {
                var result = await repository.GetById(nIdPelicula);

                response.success = true;
                response.data = (PeliculaEntity) result;
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
