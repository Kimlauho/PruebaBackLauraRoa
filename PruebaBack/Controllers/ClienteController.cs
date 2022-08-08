using BusinessRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PruebaBack.Controllers
{
    [EnableCors("*", "*", "*")]
    public class ClienteController : ApiController
    {
        [HttpGet]
        [Route("~/api/Cliente/ObtenerClientes")]
        public IHttpActionResult ObtenerClientes()
        {
            try
            {
                var result = ClienteBR.ObtenerClientes();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
