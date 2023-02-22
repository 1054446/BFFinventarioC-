using BFFinventario.Utils;
using Microsoft.AspNetCore.Mvc;
using BFFinventario.Models;

namespace BFFinventario.Controllers
{
    [ApiController]
    [Route("producto")]
    public class ProductoController : ControllerBase
    {
        string recurso = "/productos";

        [HttpGet]
        [Route("listar")]
        public dynamic listarProducto()
        {
            ConsumirAPI consumir = new ConsumirAPI();
            RespuestaApi response = consumir.consumeGet(recurso);
            return response;
        }

        [HttpPost]
        [Route("guardar")]
        public dynamic guardarProducto(Producto producto)
        {
            ConsumirAPI consumir = new ConsumirAPI();
            RespuestaApi response = consumir.consumePost(producto, recurso);
            return response;
        }

        [HttpPut]
        [Route("editar")]
        public dynamic editarProducto(Producto producto)
        {
            ConsumirAPI consumir = new ConsumirAPI();
            RespuestaApi response = consumir.consumePut(producto, recurso);
            return response;
        }

        [HttpDelete]
        [Route("eliminar")]
        public dynamic eliminarProducto(long id)
        {
            ConsumirAPI consumir = new ConsumirAPI();
            RespuestaApi response = consumir.consumeDelete(id, recurso);
            return response;
        }
    }
}
