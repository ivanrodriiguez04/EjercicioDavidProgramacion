using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDavidProgramacion.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz del menu
    /// 31/01/2024
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcion = 0;
            Console.WriteLine("|-----------------------------------|");
            Console.WriteLine("|                Menú               |");
            Console.WriteLine("|___________________________________|");
            Console.WriteLine("| 0. Cerrar menu                    |");
            Console.WriteLine("| 1. Dar alta a un nuevo cliente    |");
            Console.WriteLine("| 2. Validar a un cliente           |");
            Console.WriteLine("| 3. Modificar a un cliente         |");
            Console.WriteLine("|___________________________________|");
            Console.WriteLine("\nIntroduzca la opcion deseada;");
            opcion = Console.ReadKey(true).KeyChar - ('0');
            return opcion;
        }
    }
}
