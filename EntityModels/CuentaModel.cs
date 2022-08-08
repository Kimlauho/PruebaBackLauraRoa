using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class CuentaModel
    {
        public int? idCliente { get; set; }
        public int? idCuenta { get; set; }
        public decimal? saldo { get; set; }
        public string numeroCuenta { get; set; }
        public string nota { get; set; }
    }
}
