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
            MenuInterfaz mI = new MenuImplementacion();
            bool cerrarMenu = false;
            int opcion = 0;
            string dni = pedirDNI();
            foreach (ClienteDto cliente in listaClientesAntigua)
            {
                if (cliente.DniCliente.Equals(dni)) 
                {
                    Console.WriteLine("[INFO] - El cliente a sido encontrado y esta validado");
                    if (cliente.Concedido.Equals(true))
                    {
                        Console.WriteLine("[INFO] - El cliente esta validado");
                        opcion = mI.mostrarMenuYSeleccionModificaciones();
                        switch (opcion) 
                        {
                            case 0:
                                cerrarMenu= true;
                                break;
                            case 1:
                                Console.WriteLine("Introduzca el nuevo DNI:");
                                string nuevoDNI=Console.ReadLine();
                                cliente.DniCliente = nuevoDNI;
                                break;
                            case 2:
                                Console.WriteLine("Introduzca el nuevo nombre:");
                                string nuevoNombre = Console.ReadLine();
                                cliente.NombreCliente = nuevoNombre;
                                break;
                            case 3:
                                Console.WriteLine("Introduzca los nuevos apellidos:");
                                string nuevosApellidos = Console.ReadLine();
                                cliente.ApellidosCliente = nuevosApellidos;
                                break;
                            case 4:
                                Console.WriteLine("Introduzca el nuevo telefono:");
                                int nuevoTelefono = Convert.ToInt32(Console.ReadLine());
                                cliente.TelefonoCliente = nuevoTelefono;
                                break;
                            case 5:
                                Console.WriteLine("Introduzca el nuevo numero de seguridad social:");
                                int nuevoNumeroSS = Convert.ToInt32(Console.ReadLine());
                                cliente.NumeroSS = nuevoNumeroSS;
                                break;
                            case 6:
                                Console.WriteLine("Introduzca el nuevo color del coche:");
                                string nuevoColor = Console.ReadLine();
                                cliente.ColorCoche = nuevoColor;
                                break;
                            case 7:
                                Console.WriteLine("Introduzca el nuevo modelo del coche:");
                                string nuevoModelo = Console.ReadLine();
                                cliente.ModeloCoche = nuevoModelo;
                                break;
                            default:
                                Console.WriteLine("[INFO] - La opcion introducida no coincide con ninguna opcion mostrada anteriormente");
                                break;
                        }
                    }
                    else 
                    {
                        Console.WriteLine("[INFO] - El cliente no ha sidi validado");
                    }
                
                }
                else 
                {
                    Console.WriteLine("[INFO] - El cliento no ha sido encontrado.");
                }
            }
        }


        public void validarCliente(List<ClienteDto> listaClientesAntigua)
        {
            string dni=pedirDNI();
            foreach (ClienteDto cliente in listaClientesAntigua) 
            {
                if (cliente.DniCliente.Equals(dni))
                {
                    Console.WriteLine("[INFO] - El cliente ha sido encontrado");
                    cliente.Concedido = true;
                }
                else 
                {
                    Console.WriteLine("[INFO] - El cliente no ha sido encontrado");
                }
            }
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
