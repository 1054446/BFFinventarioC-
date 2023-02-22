using BFFinventario.Models;
using BFFinventario.Utils;
using Microsoft.AspNetCore.Mvc;

namespace BFFinventario.Controllers
{
    [ApiController]
    [Route("orden")]
    public class OrdenController : ControllerBase
    {
        string recurso = "/ordenes";

        [HttpGet]
        [Route("listar")]
        public dynamic listarOrden()
        {
            ConsumirAPI consumir = new ConsumirAPI();
            RespuestaApi response = consumir.consumeGet(recurso);
            return response;
        }

        [HttpPost]
        [Route("guardar")]
        public dynamic guardarOrden(Orden orden)
        {
            ConsumirAPI consumir = new ConsumirAPI();
            RespuestaApi response = consumir.consumePost(orden, recurso);
            return response;
        }

        [HttpPut]
        [Route("editar")]
        public dynamic editarOrden(Orden orden)
        {
            ConsumirAPI consumir = new ConsumirAPI();
            RespuestaApi response = consumir.consumePut(orden, recurso);
            return response;
        }

        [HttpDelete]
        [Route("eliminar")]
        public dynamic eliminarOrden(long id)
        {
            ConsumirAPI consumir = new ConsumirAPI();
            RespuestaApi response = consumir.consumeDelete(id, recurso);
            return response;
        }
    }
}
