using entity;
using entity.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using repository.Interfaces;

namespace services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        IClienteRepository repository;

        public ClienteController(IClienteRepository _repository) 
        {
            repository = _repository;
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<ApiResponse<ClienteEntity>>> insertCliente([FromBody] ClienteDTO cliente)
        {
            ApiResponse<ClienteEntity> response = new ApiResponse<ClienteEntity>();

            try
            {
                var result = await repository.Insert(cliente);

                response.success = true;
                response.data = (ClienteEntity) result;
                return StatusCode(200, response);
            }
            catch (Exception ex)
            {
                response.success = false;
                response.errMsj = ex.Message;
                return StatusCode(500, response);
            }
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<ApiResponse<ClienteEntity>>> getClienteByTipoNroDoc(int nIdTipoDocumento, string sDocumento)
        {
            ApiResponse<ClienteEntity> response = new ApiResponse<ClienteEntity>();

            try
            {
                var result = await repository.GetByTipoNroDoc(nIdTipoDocumento, sDocumento);

                response.success = true;
                response.data = (ClienteEntity)result;
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
