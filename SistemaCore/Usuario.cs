using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCore
{
    public class Usuario
    {
        int idJugador;
        string nombreApellido;
        string nombreUsuario;
        bool estaJugando;

        public Usuario()
        {
        }

        public Usuario(int idJugador,string nombreApellido,string nombreUsuario)
        {
            this.idJugador = idJugador;
            this.nombreApellido = nombreApellido;
            this.nombreUsuario = nombreUsuario;
            this.estaJugando = false;
        }

        public string NombreApellido { get => nombreApellido; set => nombreApellido = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public bool EstaJugando { get => estaJugando; set => estaJugando = value; }
        public int IdJugador { get => idJugador; set => idJugador = value; }

        public override string ToString()
        {
            return NombreUsuario;
        }
    }
}
