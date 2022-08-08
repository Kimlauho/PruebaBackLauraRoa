using BusinessRules;
using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PruebaBack.Controllers
{
    [EnableCors("*", "*", "*")]
    public class CuentaController : ApiController
    {
        [HttpGet]
        [Route("~/api/Cuenta/ObtenerCuentas/{idCliente}")]
        public IHttpActionResult ObtenerCuentas(int idCliente)
        {
            try
            {
                var result = CuentaBR.ObtenerCuentas(idCliente);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("~/api/Cuenta/CrearCuenta")]
        public IHttpActionResult CrearCuenta(CuentaModel cuenta)
        {
            try
            {
                var result = CuentaBR.CrearCuenta(cuenta);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}