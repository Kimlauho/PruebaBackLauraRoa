using DataModels.DataManagers;
using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRules
{
    public class ClienteBR
    {
        public static List<ClienteModel> ObtenerClientes()
        {
            return ClienteManager.ObtenerClientes();
        }
    }
}
