using entity;
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

        [HttpPost]
        public async Task<ActionResult<ApiResponse<ReservaEntity>>> insertReserva([FromBody] ReservaEntity reserva)
        {
            ApiResponse<ReservaEntity> response = new ApiResponse<ReservaEntity>();

            try
            {
                var result = await repository.Insert(reserva);

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
