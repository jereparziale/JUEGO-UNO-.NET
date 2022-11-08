using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCore
{
    public class Jugador
    {
        int idJugador;
        string nombreUsuario;
        List<ICarta> manoCartasJugador;

        public Jugador()
        {

        }

        public Jugador(int idJugador, string nombreUsuario)
        {
            this.idJugador = idJugador;
            this.manoCartasJugador = new List<ICarta>();
            this.nombreUsuario = nombreUsuario;
        }

        public List<ICarta> ManoCartasJugador { get => manoCartasJugador; set => manoCartasJugador = value; }

        public int CartasRestantes { get => manoCartasJugador.Count; }

        public ICarta TomarCarta { set => manoCartasJugador.Add(value); }
        public int IdJugador { get => idJugador; set => idJugador = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }

        public EColores ElegirColorComodin()
        {
            Random rdn = new Random();
            int rdnInt = rdn.Next(1, 4);
            switch (rdnInt)
            {
                case 1:
                    return EColores.Azul;
                case 2:
                    return EColores.Rojo;
                case 3:
                    return EColores.Verde;
                case 4:
                    return EColores.Amarillo;
                default:
                    break;
            }
            return EColores.Negro; //OJOOOO
        }
    }
}
