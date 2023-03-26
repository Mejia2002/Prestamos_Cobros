using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clientes
    {
        private List<IPersona> listaClientes;

        public Clientes()
        {
            listaClientes = new List<IPersona>();
        }

        public void AgregarCliente(IPersona cliente)
        {
            listaClientes.Add(cliente);
        }

        public void MostrarClientes()
        {
            foreach (IPersona cliente in listaClientes)
            {
                Console.WriteLine("Nombre: " + cliente.Nombre);
                Console.WriteLine("Tipo de documento: " + cliente.TipoDocumento);
                Console.WriteLine("Número de documento: " + cliente.NumeroDocumento);
                Console.WriteLine("Dirección: " + cliente.Direccion);
                Console.WriteLine("Ciudad: " + cliente.Ciudad);
                Console.WriteLine("Correo: " + cliente.Correo);
                Console.WriteLine("Teléfono: " + cliente.Telefono);
                Console.WriteLine();
            }
        }
    }

}
