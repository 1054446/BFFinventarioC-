using BFFinventario.Models;
using BFFinventario.Utils;
using Microsoft.AspNetCore.Mvc;

namespace BFFinventario.Controllers
{
    [ApiController]
    [Route("precio")]
    public class PrecioController : ControllerBase
    {
        string recurso = "/precios";

        [HttpGet]
        [Route("listar")]
        public dynamic listarPrecio()
        {
            ConsumirAPI consumir = new ConsumirAPI();
            RespuestaApi response = consumir.consumeGet(recurso);
            return response;
        }

        [HttpPost]
        [Route("guardar")]
        public dynamic guardarPrecio(Precio precio)
        {
            ConsumirAPI consumir = new ConsumirAPI();
            RespuestaApi response = consumir.consumePost(precio, recurso);
            return response;
        }

        [HttpPut]
        [Route("editar")]
        public dynamic editarPrecio(Precio precio)
        {
            ConsumirAPI consumir = new ConsumirAPI();
            RespuestaApi response = consumir.consumePut(precio, recurso);
            return response;
        }

        [HttpDelete]
        [Route("eliminar")]
        public dynamic eliminarPrecio(long id)
        {
            ConsumirAPI consumir = new ConsumirAPI();
            RespuestaApi response = consumir.consumeDelete(id, recurso);
            return response;
        }
    }
}
