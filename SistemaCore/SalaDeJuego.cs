using AccesoADatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SistemaCore
{
    public class SalaDeJuego
    {
        string descripcion;
        Jugador jugador1;
        Jugador jugador2;
        List<Partida> listadoDePartidas;
        CancellationTokenSource cancelToken;
        public delegate void EventoMostrarPartidaFinalizada(SalaDeJuego b);
        public event EventoMostrarPartidaFinalizada EMostrarPartidaFinalizada;
        public delegate void EventoCancelarFinalizarPartida(string x,ICarta carta);
        public event EventoCancelarFinalizarPartida ECancelarFinalizarPartida;

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

        public CancellationTokenSource CancelToken
        {
            get
            {
                if (cancelToken is null || cancelToken.IsCancellationRequested)
                {
                    cancelToken = new CancellationTokenSource();
                }

                return cancelToken;
            }
        }

        public override string ToString()
        {
            return descripcion;
        }

        public void Jugar(CancellationToken cT)
        {
            int contador = 0;
            listadoDePartidas.Add(new Partida(Jugador1, Jugador2));
            PartidaEnJuego.InicioDelJuego();
            do
            {
                Task.Delay(2000).Wait();
                PartidaEnJuego.JugarMano();
                contador++;
            } while (contador < Sistema.Configuracion.CantidadDeManos && (jugador1.CartasRestantes > 0 && jugador2.CartasRestantes > 0) && !cT.IsCancellationRequested);
            
            if(cT.IsCancellationRequested)
            {
                PartidaEnJuego.EstadoPartida = EEstadosPartidas.Cancelado;
                PartidaEnJuego.SbMensajeJuego.Append("----------PARTIDA CANCELADA----------");
                ECancelarFinalizarPartida(PartidaEnJuego.SbMensajeJuego.ToString(),null);
            }
            else
            {
                string mensajeGanador = PartidaEnJuego.DeclararGanador();
                PartidaEnJuego.SbMensajeJuego.Append(mensajeGanador);
                PartidasDAO.AgregarPartida(PartidaEnJuego);
                if(EMostrarPartidaFinalizada != null)
                    EMostrarPartidaFinalizada(this);
                
                if(ECancelarFinalizarPartida != null)
                    ECancelarFinalizarPartida(PartidaEnJuego.SbMensajeJuego.ToString(), null);
            }

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

        public bool suscribirEventoMostrarEstadistica()
        {
            if (EMostrarPartidaFinalizada is null)
                return true;
            else
                return false;
        }

        
    }
}
