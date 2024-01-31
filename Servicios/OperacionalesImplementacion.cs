using EjercicioDavidProgramacion.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDavidProgramacion.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz de las operaciones de la lista
    /// irodhan -> 31/01/2024
    /// </summary>
    internal class OperacionalesImplementacion : OperacionalesInterfaz
    {
        public void altaCliente(List<ClienteDto> listaClientesAntigua)
        {
            ClienteDto nuevoCliente = crearCliente();
            listaClientesAntigua.Add(nuevoCliente);
        }
        /// <summary>
        /// Metodo que pide toda la informacion al usuario
        /// irodhan -> 31/01/2024
        /// </summary>
        /// <returns></returns>
        private ClienteDto crearCliente() 
        { 
            ClienteDto cliente = new ClienteDto();
            Console.WriteLine("Introduzca el id del cliente: ");
            cliente.IdCliente=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el dni del cliente: ");
            cliente.DniCliente = Console.ReadLine();
            Console.WriteLine("Introduzca el nombre del cliente: ");
            cliente.NombreCliente = Console.ReadLine();
            Console.WriteLine("Introduzca los apellidos del cliente: ");
            cliente.ApellidosCliente = Console.ReadLine();
            Console.WriteLine("Introduzca el telefono del cliente: ");
            cliente.TelefonoCliente = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el numero de la seguridad social: ");
            cliente.NumeroSS=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el color del coche: ");
            cliente.ColorCoche = Console.ReadLine();
            Console.WriteLine("Introduzca el modelo del coche: ");
            cliente.ModeloCoche = Console.ReadLine();
            return cliente;
        }
        public void modificarCliente(List<ClienteDto> listaClientesAntigua)
        {
            string dni = pedirDNI();
        }


        public void validarCliente(List<ClienteDto> listaClientesAntigua)
        {
            throw new NotImplementedException();
        } 
        
        /// <summary>
        /// Metodo que pide el dni del cliente a validar o modificar
        /// irodhan -> 31/01/2024
        /// </summary>
        /// <returns></returns>
        private string pedirDNI() 
        {
            string DNI = "aaaaa";
            Console.WriteLine("Introduzca el DNI del cliente a modificar: ");
            DNI=Console.ReadLine();
            return DNI;
        }
    }
}
