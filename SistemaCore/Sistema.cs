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
            baraja = Serializadora<Baraja>.LeerJSON("baraja_Datos");
            baraja.LlenarListaICarta();
        }

        

        public static List<Usuario> ListadoDeUsuarios { get => listadoDeUsuarios;}
        public static List<SalaDeJuego> ListadoSalas { get => listadoSalas; }
        public static Configuracion Configuracion { get => configuracion; set => configuracion = value; }
        public static Baraja Baraja { get => baraja; }//HACER QUQE RETORNE LA BARAJA MEZCLADA

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

        public static void GuardarPartidasArchivoSql()
        {
            foreach (SalaDeJuego sala in listadoSalas)
            {
                foreach (Partida item in sala.ListadoDePartidas)
                {
                    
                    if (item.EstadoPartida == EEstadosPartidas.Finalizado)
                    {
                        DateTime fecha = DateTime.Now;
                        PartidasDAO.AgregarPartida(item);
                        ManejadorArchivo.Escribir(item.SbMensajeJuego.ToString(), $"{fecha.ToString("dd-mm-yy")}-{item.Jugador1.NombreUsuario}-{item.Jugador2.NombreUsuario}");
                    }
                }
            }
            
        }
    }
}
