using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.DataManagers
{
    public class ClienteManager
    {
        // obtiene los clientes registrados en el sistema
        public static List<ClienteModel> ObtenerClientes()
        {
            try
            {
                using (PruebaLauraRoaEntities db = new PruebaLauraRoaEntities())
                {
                    return db.sp_ObtenerClientes().AsEnumerable().Select(x => new ClienteModel()
                    {
                        idCliente = x.idCliente,
                        numeroIdentificacion = x.numeroIdentificacion,
                        nombres = x.nombres,
                        apellidos = x.apellidos,
                        razonSocial = x.razonSocial,
                        celular = x.celular,
                        telefono = x.telefono,
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
