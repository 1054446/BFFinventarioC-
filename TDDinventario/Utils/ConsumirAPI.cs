using Newtonsoft.Json;
using RestSharp;
using BFFinventario.Models;

namespace BFFinventario.Utils
{
    public class ConsumirAPI
    {        
        
        public dynamic consumeGet(string recurso)
        {
            var url = "http://localhost:8080/inventario/v1" + recurso;

            var client = new RestClient(url);
            var response = client.Execute<RespuestaApi>(new RestRequest());
            return response.Data;
        }

        public dynamic consumePost(object cliente, string recurso)
        {
            var url = "http://localhost:8080/inventario/v1" + recurso;

            var body = cliente;

            var client = new RestClient(url);
            var request = new RestRequest();
            request.AddJsonBody(body);
            var response = client.Post(request);
            RespuestaApi respuestaApi = JsonConvert.DeserializeObject<RespuestaApi>(response.Content);

            return respuestaApi;
        }

        public dynamic consumePut(object cliente, string recurso)
        {
            var url = "http://localhost:8080/inventario/v1" + recurso;

            var body = cliente;

            var client = new RestClient(url);
            var request = new RestRequest();
            request.AddJsonBody(body);
            var response = client.Put(request);
            RespuestaApi respuestaApi = JsonConvert.DeserializeObject<RespuestaApi>(response.Content);

            return respuestaApi;
        }

        public dynamic consumeDelete(long id, string recurso)
        {
            var url = "http://localhost:8080/inventario/v1" + recurso + "/" + id;

            var client = new RestClient(url);
            var request = new RestRequest();
            var response = client.Delete(request);
            RespuestaApi respuestaApi = JsonConvert.DeserializeObject<RespuestaApi>(response.Content);

            return respuestaApi;
        }
    }
}
