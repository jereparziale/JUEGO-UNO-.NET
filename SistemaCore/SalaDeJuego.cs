using AccesoADatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCore
{
    public class SalaDeJuego
    {
        string descripcion;
        Jugador jugador1;
        Jugador jugador2;
        List<Partida> listadoDePartidas;

        public SalaDeJuego(string descripcion, Jugador jugador1, Jugador jugador2)
        {
            this.descripcion = descripcion;
            this.jugador1 = jugador1;
            this.jugador2 = jugador2;
            listadoDePartidas = new List<Partida>();
        }

        public Jugador Jugador1 { get => jugador1;}
        public Jugador Jugador2 { get => jugador2;}
        public string Descripcion { get => descripcion; }
        public Partida PartidaEnJuego { get => listadoDePartidas.Last(); }
        public List<Partida> ListadoDePartidas { get => listadoDePartidas; }

        public override string ToString()
        {
            return descripcion;
        }

        public void Jugar(Action<string, string> delegadoUI, Action<string,Partida> delegadoUIGanador)
        {
            int contador = 0;

            if(ListadoDePartidas.Count>0)
            if (PartidaEnJuego.EstadoPartida == EEstadosPartidas.Jugando) //FALTA PAUSADO
                throw new Exception("Aun se encuentra una partida en juego");

            listadoDePartidas.Add(new Partida(Jugador1, Jugador2, delegadoUI));
            PartidaEnJuego.InicioDelJuego();
            do
            {
                Task.Delay(1000).Wait();
                PartidaEnJuego.Desarrollo();
                contador++;
            } while (contador < 20 && (jugador1.CartasRestantes > 0 && jugador2.CartasRestantes > 0));
            
            //GANADOR
            string mensajeGanador= PartidaEnJuego.DeclararGanador();
            PartidaEnJuego.SbMensajeJuego.Append(mensajeGanador);
            delegadoUIGanador(mensajeGanador,PartidaEnJuego);

        }

        public void PartidasGanadasPorSala(out int ganadasJ1,out int ganadasJ2)
        {
            ganadasJ1 = 0;
            ganadasJ2 = 0;
            foreach (Partida item in ListadoDePartidas)
            {
                if (item.JugadorGanador != null)
                    if (item.JugadorGanador.Equals(jugador1))
                        ganadasJ1++;
                    else
                        ganadasJ2++;
            }
        } 
        public void PartidasGanadasPorSala(out int ganadasJ1,out int ganadasJ2,out int ganadasSinCartas)
        {
            ganadasJ1 = 0;
            ganadasJ2 = 0;
            ganadasSinCartas = 0;
            foreach (Partida item in ListadoDePartidas)
            {
                if (item.JugadorGanador != null)
                    if (item.JugadorGanador.Equals(jugador1))
                        ganadasJ1++;
                    else
                        ganadasJ2++;

                if (item.JugadorGanador != null)
                    if (item.JugadorGanador.CartasRestantes == 0)
                        ganadasSinCartas++;
            }
        }

        public void EstadisticasPorCartaPorSala(out int cantidasMasCuatro,out int cantidadMasDos,out int cantidadBloqueoReversa)
        {
            cantidadMasDos = 0;
            cantidasMasCuatro = 0;
            cantidadBloqueoReversa = 0;

            foreach (Partida item in ListadoDePartidas)
            {
                cantidadMasDos += item.CantidadMasDosUsados;
                cantidasMasCuatro += item.CantidadMasCuatroUsados;
                cantidadBloqueoReversa += item.CantidadBloqueoReversa;
            }
        }

        
    }
}
