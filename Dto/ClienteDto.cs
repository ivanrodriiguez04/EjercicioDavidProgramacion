using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDavidProgramacion.Dto
{
    /// <summary>
    /// Clase del objeto cliente donde se almacena toda la informacion necesario
    /// irodhan -> 31/01/2024
    /// </summary>
    internal class ClienteDto
    {
        //Atributos
        int idCliente;
        string dniCliente = "aaaaa";
        string nombreCliente = "aaaaa";
        string apellidosCliente = "aaaaa";
        int telefonoCliente = 0;
        bool concedido=false;
        int numeroSS = 0;
        string colorCoche = "aaaaa";
        string modeloCoche = "aaaaa";
        
        //Constructores
        public ClienteDto()
        {
        }
        public ClienteDto(int idCliente, string dniCliente, string nombreCliente, string apellidosCliente, int telefonoCliente, bool concedido, int numeroSS, string colorCoche, string modeloCoche)
        {
            this.IdCliente = idCliente;
            this.DniCliente = dniCliente;
            this.NombreCliente = nombreCliente;
            this.ApellidosCliente = apellidosCliente;
            this.TelefonoCliente = telefonoCliente;
            this.Concedido = concedido;
            this.NumeroSS = numeroSS;
            this.ColorCoche = colorCoche;
            this.ModeloCoche = modeloCoche;
        }

        //Getters & Setters
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public int TelefonoCliente { get => telefonoCliente; set => telefonoCliente = value; }
        public bool Concedido { get => concedido; set => concedido = value; }
        public int NumeroSS { get => numeroSS; set => numeroSS = value; }
        public string ColorCoche { get => colorCoche; set => colorCoche = value; }
        public string ModeloCoche { get => modeloCoche; set => modeloCoche = value; }


    }
}
