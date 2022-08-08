using DataModels.DataManagers;
using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRules
{
    public class CuentaBR
    {
        public static List<CuentaModel> ObtenerCuentas(int idCliente)
        {
            return CuentaManager.ObtenerCuentas(idCliente);
        }

        public static CuentaModel CrearCuenta(CuentaModel cuenta)
        {
            return CuentaManager.CrearCuenta(cuenta);
        }
    }
}
