using entity;
using entity.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using repository.Interfaces;

namespace services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : ControllerBase
    {
        IReservaRepository repository;

        public ReservaController(IReservaRepository _repository)
        {
            repository = _repository;
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<ApiResponse<ReservaEntity>>> insertReserva([FromBody] ReservaDTO reserva)
        {
            ApiResponse<ReservaEntity> response = new ApiResponse<ReservaEntity>();

            try
            {
                var result = await repository.Insert(reserva);
                result = await repository.GetById(result.nIdReserva);

                response.success = true;
                response.data = (ReservaEntity)result;
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
