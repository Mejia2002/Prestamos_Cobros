using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cobrar : IPersona
    {
        public string Nombre { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public int CuotaPendiente { get; set; }
        public DateTime FechaLimite { get; set; }
        public decimal ImporteAPagar { get; set; }
    }

}
