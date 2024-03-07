using entity;
using Microsoft.AspNetCore.Mvc;
using repository.Interfaces;

namespace services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaController : ControllerBase
    {
        public readonly ISalaRepository repository;

        public SalaController(ISalaRepository _repository)
        {
            repository = _repository;
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<ApiResponse<List<SalaEntity>>>> GetListSala()
        {
            ApiResponse<List<SalaEntity>> response = new ApiResponse<List<SalaEntity>>();

            try
            {
                var result = await repository.GetListSala();

                response.success = true;
                response.data = (List<SalaEntity>)result;
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