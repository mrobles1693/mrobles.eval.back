using entity;
using entity.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using repository.Interfaces;

namespace services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaPeliculaController : ControllerBase
    {
        public readonly ISalaPeliculaRepository repository;

        public SalaPeliculaController(ISalaPeliculaRepository _repository)
        {
            repository = _repository;
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<ApiResponse<List<SalaPeliculaEntity>>>> getSalaPelicula([FromBody] SalaPeliculaFilterDTO filtros)
        {
            ApiResponse<List<SalaPeliculaEntity>> response = new ApiResponse<List<SalaPeliculaEntity>>();

            try
            {
                var result = await repository.GetListPeliculasByFilters(filtros);

                response.success = true;
                response.data = (List<SalaPeliculaEntity>) result;
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
