using BFFinventario.Utils;
using Microsoft.AspNetCore.Mvc;
using BFFinventario.Models;

namespace TDDinventario.Controllers
{
    [ApiController]
    [Route("cliente")]
    public class ClienteController : ControllerBase
    {
        string recurso = "/clientes";

        [HttpGet]
        [Route("listar")]
        public dynamic listarCliente() {
            ConsumirAPI consumir = new ConsumirAPI();
            RespuestaApi response = consumir.consumeGet(recurso);
            return response;
        }

        [HttpPost]
        [Route("guardar")]
        public dynamic guardarCliente(Cliente cliente) {
            ConsumirAPI consumir = new ConsumirAPI();
            RespuestaApi response = consumir.consumePost(cliente, recurso);
            return response;
        }

        [HttpPut]
        [Route("editar")]
        public dynamic editarCliente(Cliente cliente)
        {
            ConsumirAPI consumir = new ConsumirAPI();
            RespuestaApi response = consumir.consumePut(cliente, recurso);
            return response;
        }

        [HttpDelete]
        [Route("eliminar")]
        public dynamic eliminarCliente(long id)
        {
            ConsumirAPI consumir = new ConsumirAPI();
            RespuestaApi response = consumir.consumeDelete(id, recurso);
            return response;
        }

    }
}
