using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.DataManagers
{
    public class TransaccionManager
    {
        // registra la transaccion y devuelve nota confirmacion de la transaccion
        public static TransaccionModel CrearTransaccion(TransaccionModel t)
        {
            try
            {
                using (PruebaLauraRoaEntities db = new PruebaLauraRoaEntities())
                {
                    return db.sp_CrearTransaccion(t.idCliente, t.idCuenta, t.valor, t.idTipoTransaccion).AsEnumerable().Select(x => new TransaccionModel()
                    {
                        nota = x.nota
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
