using entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using repository.Interfaces;

namespace services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoDocumentoController : ControllerBase
    {
        public readonly ITipoDocumentoRepository repository;

        public TipoDocumentoController(ITipoDocumentoRepository _repository)
        {
            repository = _repository;
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<ApiResponse<List<TipoDocumentoEntity>>>> GetListTipoDocumento()
        {
            ApiResponse<List<TipoDocumentoEntity>> response = new ApiResponse<List<TipoDocumentoEntity>>();

            try
            {
                var result = await repository.GetListTipoDocumento();

                response.success = true;
                response.data = (List<TipoDocumentoEntity>)result;
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
