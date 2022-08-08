using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class ClienteModel
    {
        public int? idCliente { get; set; } 
        public int? idTipoIdentificacion { get; set; } 
        public string numeroIdentificacion { get; set; } 
        public string nombres { get; set; } 
        public string apellidos { get; set; } 
        public string razonSocial { get; set; } 
        public string celular { get; set; } 
        public string telefono { get; set; } 
        public string municipio { get; set; } 
        public string departamento { get; set; } 
        public string nota { get; set; } 
    }
}
