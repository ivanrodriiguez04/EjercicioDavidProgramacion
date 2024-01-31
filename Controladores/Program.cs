using EjercicioDavidProgramacion.Dto;
using EjercicioDavidProgramacion.Servicios;

namespace EjercicioDavidProgramacion.Controladores
{
    /// <summary>
    /// Clase princicpal de la aplicacion
    /// irodhan -> 31/01/2024
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo princicpal de la aplicacion
        /// irodhan -> 31/01/2024
        /// </summary>
        static void Main(string[] args)
        {
            //Listas
            List<ClienteDto> listaClientes = new List<ClienteDto>();
            //Objetos
            MenuInterfaz mI = new MenuImplementacion();
            OperacionalesInterfaz oI = new OperacionalesImplementacion();
            //Atributos
            int opcionSeleccionada = 0;
            bool cerrarMenu = false;

            //Comenzamos con el bucle de la aplicacion
            while (!cerrarMenu)
            {
                opcionSeleccionada = mI.mostrarMenuYSeleccion();
                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("[INFO] - Ha seleccionado la opcion cerrar menu");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("[INFO] -  Ha seleccionado la opcion de dar alta al cliente");
                        oI.altaCliente(listaClientes);
                        break;
                    case 2:
                        Console.WriteLine("[INFO] -  Ha seleccionado la opcion de validar al cliente");
                        oI.validarCliente(listaClientes);
                        break;
                    case 3:
                        Console.WriteLine("[INFO] -  Ha seleccionado la opcion de modificar al cliente");
                        oI.modificarCliente(listaClientes);
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna opcion mostrada anteriormente");
                        break;

                }
            }
        }
    }
}