using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BMSR11092023CokiesProfe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //Aplica la autorizacion a este controlador, lo que significa solo
    //los usuarios autenticados podran acceder a sus acciones
    [Authorize]
    public class ProtetedController : ControllerBase
    {
        //Crea una lista de objetos 'data' para almacenar informacion
        static List<object> data = new List<object>();

        [HttpGet]
        public IEnumerable<object> Get()
        {
            //Devuelve los datos almacenados en la lista 'data' en respuesta a una solicitud GET
            return data;
        }
        [HttpPost]
        public IActionResult Post(string name, string lastname)
        {
            //Agrega un nuevo objeto anonimo con 'name' y 'lastName'
            //a la lista 'data' en respuesta a una solicitud POST 
            data.Add(new { name, lastname });
            //Devuelve una respuesta HTTP exitosa
            return Ok();
        }
    }
}
