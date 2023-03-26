using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Presentacion
{
    internal class Prueba
    {
        static void Main(string[] args)
        {
            Prestar prestamo = new Prestar();
            prestamo.Nombre = "Neider";
            prestamo.TipoDocumento = "Cedula";
            prestamo.NumeroDocumento = "12345678";
            prestamo.Direccion = "Carrera 4 calle 7";
            prestamo.Ciudad = "Lima";
            prestamo.Correo = "estudianteupc@gmail.com";
            prestamo.Telefono = "458582525";
            prestamo.MontoPrestamo = 1000000;
            prestamo.NumeroCuotas = 12;
            prestamo.FormaPago = "Mensual";
            Console.ReadKey();
        }
    }
}
