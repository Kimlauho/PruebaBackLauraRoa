using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.DataManagers
{
    public class CuentaManager
    {
        // obtiene el listado de las cuentas por cliente registradas en el sistema
        public static List<CuentaModel> ObtenerCuentas(int idCliente)
        {
            try
            {
                using (PruebaLauraRoaEntities db = new PruebaLauraRoaEntities())
                {
                    return db.sp_ObtenerCuentas(idCliente).AsEnumerable().Select(x => new CuentaModel()
                    {
                        idCuenta = x.idCuenta,
                        saldo = x.saldo,
                        numeroCuenta = x.numeroCuenta
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        // registra una cuenta y la asocia a un cliente
        public static CuentaModel CrearCuenta(CuentaModel c)
        {
            try
            {
                using (PruebaLauraRoaEntities db = new PruebaLauraRoaEntities())
                {
                    return db.sp_CrearCuenta(c.idCliente, c.numeroCuenta, c.saldo).AsEnumerable().Select(x => new CuentaModel()
                    {
                        nota = x.nota,
                    }).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
