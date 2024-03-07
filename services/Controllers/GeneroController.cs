using entity;
using Microsoft.AspNetCore.Mvc;
using repository.Interfaces;

namespace services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneroController : ControllerBase
    {
        public readonly IGeneroRepository repository;

        public GeneroController(IGeneroRepository _repository)
        {
            repository = _repository;
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<ApiResponse<List<GeneroEntity>>>> GetListGenero()
        {
            ApiResponse<List<GeneroEntity>> response = new ApiResponse<List<GeneroEntity>>();

            try
            {
                var result = await repository.GetListGenero();

                response.success = true;
                response.data = (List<GeneroEntity>)result;
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
