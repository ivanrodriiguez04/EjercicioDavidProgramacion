using EjercicioDavidProgramacion.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDavidProgramacion.Servicios
{
    /// <summary>
    /// Interfaz de las metodos de la aplicacion
    /// irodhan -> 31/01/2024
    /// </summary>
    internal interface OperacionalesInterfaz
    {
        /// <summary>
        /// Metodo que da el alta a un nuevo cliente
        /// irodhan -> 31/01/2024
        /// </summary>
        /// <param name="listaClientesAntigua"></param>
        public void altaCliente(List<ClienteDto> listaClientesAntigua);

        /// <summary>
        /// Metodo que valida a un cliente
        /// irodhan -> 31/01/2024
        /// </summary>
        /// <param name="listaClientesAntigua"></param>
        public void validarCliente(List<ClienteDto> listaClientesAntigua);

        /// <summary>
        /// Metodo que modifica la informacion guardada
        /// irodhan -> 31/01/2024
        /// </summary>
        /// <param name="listaClientesAntigua"></param>
        public void modificarCliente(List<ClienteDto> listaClientesAntigua);
    }
}
