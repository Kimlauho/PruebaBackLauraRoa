using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class TransaccionModel
    {
        public int? idTransaccion { get; set; }
        public int? idTipoTransaccion { get; set; }
        public int? idCliente { get; set; }
        public int? idCuenta { get; set; }
        public decimal? valor { get; set; }
        public DateTime? fecha { get; set; }
        public string nota { get; set; }
    }
}
