using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDavidProgramacion.Servicios
{
    /// <summary>
    /// Interfaz del menu de la aplicacion
    /// irodhan -> 31/01/2024
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que muestra y obtiene la opcion seleccionada por el usuario
        /// irodhan -> 31/01/2024   
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSeleccion();

        /// <summary>
        /// Metodo que muestra el menu de modificaciones del cliente
        /// irodhan -> 31/01/2024
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSeleccionModificaciones();
    }
}
