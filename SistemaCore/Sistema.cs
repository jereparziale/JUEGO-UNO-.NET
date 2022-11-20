using AccesoADatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SistemaCore
{
    public static class Sistema
    {
        static List<Usuario> listadoDeUsuarios;
        static List<SalaDeJuego> listadoSalas;
        static Random rdn;
        static Configuracion configuracion;
        static Baraja baraja;

        

        static Sistema()
        {
            listadoDeUsuarios = UsuariosDAO.ObtenerClientes();
            listadoSalas = new List<SalaDeJuego>();
            rdn = new Random();
            configuracion = Serializadora<Configuracion>.LeerJSON("config");
            //baraja = new Baraja();
            //baraja.CrearCartas();
            //Serializadora<Baraja>.EscribirJSON(baraja,"baraja_Datos");
            baraja = Serializadora<Baraja>.LeerJSON("baraja_Datos");
            baraja.LlenarListaICarta();
        }

        

        public static List<Usuario> ListadoDeUsuarios { get => listadoDeUsuarios;}
        public static List<SalaDeJuego> ListadoSalas { get => listadoSalas; }
        public static Configuracion Configuracion { get => configuracion; set => configuracion = value; }
        public static Baraja Baraja { get => baraja; }

        public static void AgregarSala()
        {
            Jugador jugador1;
            Jugador jugador2;
            try
            {
                SeleccionarJugadorAleatorio(out jugador1);
                SeleccionarJugadorAleatorio(out jugador2);
                listadoSalas.Add(new SalaDeJuego($"UNO {jugador1.NombreUsuario} vs {jugador2.NombreUsuario}", jugador1, jugador2));
            }
            catch (Exception)
            {
                throw;
            }
        } 
        public static void JugarPartida(SalaDeJuego sala,Action<string,string> mostrarExcepciones)
        {
            if (sala.ListadoDePartidas.Count > 0)
                if (sala.PartidaEnJuego.EstadoPartida == EEstadosPartidas.Jugando)
                {
                    mostrarExcepciones("Aun se encuentra una partida en juego", "Error");
                    return;
                }

            Task.Run(() => sala.Jugar(sala.CancelToken.Token));
            Task.Delay(500).Wait();
        }



        public static void SeleccionarJugadorAleatorio(out Jugador jugador)
        {
            jugador = new Jugador();

            if (ListadoDeUsuarios.Count == 0)
                throw new Exception("No hay suficientes jugadores registrados");

            if(VerCantidadJugadoresDisponibles()==0)
                throw new Exception("Todos los jugadores se encuentran en una partida actualmente");

            jugador = ExtraerJugadorDisponible(jugador);

            if(jugador is null)
                throw new Exception("Error al extraer jugadores");

        }

        private static int VerCantidadJugadoresDisponibles()
        {
            int jugadoresDisponibles = 0;

            foreach (Usuario item in ListadoDeUsuarios)
            {
                if (!item.EstaJugando)
                    jugadoresDisponibles++;
            }
            return jugadoresDisponibles;
            //if (ListadoDeUsuarios.ForEach(x =>
            //{
            //    if (x.EstaJugando == true)
            //    {
            //        jugadoresDisponibles++;
            //    }
            //});
        }
        
        private static List<Usuario> VerListadoJugadoresDisponibles()
        {
            List<Usuario> jugadoresDisponibles = new List<Usuario>();

            foreach (Usuario item in ListadoDeUsuarios)
            {
                if (!item.EstaJugando)
                    jugadoresDisponibles.Add(item);
            }
            return jugadoresDisponibles;
        }

        private static Jugador ExtraerJugadorDisponible(Jugador jugador)
        {
            Usuario usuarioAux;
            int indexRdn;
            List<Usuario> listadoAux = VerListadoJugadoresDisponibles();
            do
            {
                indexRdn = rdn.Next(0, listadoAux.Count - 1);
                usuarioAux = listadoAux[indexRdn];
            } while (usuarioAux.EstaJugando);

            usuarioAux.EstaJugando = true;
            jugador.IdJugador = usuarioAux.IdJugador;
            jugador.NombreUsuario = usuarioAux.NombreUsuario;
            return jugador;
        }

        public static void GuardarPartidasEnArchivo()
        {
            foreach (SalaDeJuego sala in listadoSalas)
            {
                foreach (Partida item in sala.ListadoDePartidas)
                {
                    if (item.EstadoPartida == EEstadosPartidas.Finalizado)
                    {
                        DateTime fecha = DateTime.Now;
                        ManejadorArchivo.Escribir(item.SbMensajeJuego.ToString(), $"{fecha.ToString("d-MM-yyyy")}-{item.Jugador1.NombreUsuario}-{item.Jugador2.NombreUsuario}");
                    }
                }
            }
        }


        public static void ObtenerEstadisticaCantidadPartidas(Action<string> DelegadoUI)
        {
            string query = "SELECT COUNT(IdPartida) AS PARTIDAS  FROM Partidas";
            string mensaje = "La cantidad de partidas registradas en sistema es de:";
            PartidasDAO.ObtenerEstadisticasInt(DelegadoUI, query, mensaje);
        } 
        
        public static void ObtenerEstadisticaCantidadEmpates(Action<string> DelegadoUI)
        {
            string query = "SELECT COUNT(idJugadorGanador) CantidadEmpates FROM Partidas\r\nWHERE idJugadorGanador=0";
            string mensaje = "La cantidad de partidas finalizadas en empate es de:";
            PartidasDAO.ObtenerEstadisticasInt(DelegadoUI, query, mensaje);
        }
        
        public static void ObtenerEstadisticaCantidadSinCartas(Action<string> DelegadoUI)
        {
            string query = "SELECT COUNT(idJugadorGanador) CantidadSinCartas FROM Partidas\r\nWHERE IdJugadorGanador=IdJugador1 AND CartasRestantesJ1=0\r\nOR IdJugadorGanador=IdJugador2 AND CartasRestantesJ2=0";
            string mensaje = "La cantidad de partidas con ganador sin cartas es de:";
            PartidasDAO.ObtenerEstadisticasInt(DelegadoUI, query, mensaje);
        }
        
        public static void ObtenerEstadisticaHistorialJugadores(Action<string> DelegadoUI,int jugador1,int jugador2)
        {
            PartidasDAO.ObtenerEstadisticasHistorialJugadores(jugador1, jugador2, out int ganadasj1);
            PartidasDAO.ObtenerEstadisticasHistorialJugadores(jugador2, jugador1, out int ganadasj2);
            if(ganadasj1!=0 && ganadasj2 !=0)
                DelegadoUI($"El historial es de {ganadasj1} a {ganadasj2}");
            else
                DelegadoUI($"No hay enfrentamientos registrados");
        }
    }
}
