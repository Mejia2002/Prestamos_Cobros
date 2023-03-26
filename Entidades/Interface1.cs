using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IPersona
    {
        string Nombre { get; set; }
        string TipoDocumento { get; set; }
        string NumeroDocumento { get; set; }
        string Direccion { get; set; }
        string Ciudad { get; set; }
        string Correo { get; set; }
        string Telefono { get; set; }
    }
}
