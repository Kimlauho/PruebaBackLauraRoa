using BusinessRules;
using EntityModels;
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
    public class TransaccionController : ApiController
    {
        [HttpPost]
        [Route("~/api/Transaccion/CrearTransaccion")]
        public IHttpActionResult CrearTransaccion(TransaccionModel Transaccion)
        {
            try
            {
                var result = TransaccionBR.CrearTransaccion(Transaccion);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
