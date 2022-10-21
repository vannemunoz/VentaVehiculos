using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using VentaVehiculos.Clases;
using VentaVehiculos.Models;

namespace VentaVehiculos.Controllers
{
    public class VehiculoController : ApiController
    {
        [EnableCors(origins: "http://localhost:53613", headers: "*", methods: "*")]
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public String Post([FromBody] Vehiculo vehiculo)
        {
            clsVehiculo ormVehiculo = new clsVehiculo();
            ormVehiculo.vehiculo = vehiculo;
            return ormVehiculo.GrabarVehiculo();

        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}