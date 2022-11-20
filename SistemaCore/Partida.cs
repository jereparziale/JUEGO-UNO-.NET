using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCore
{

    public class Partida
    {
        Jugador jugador1;
        Jugador jugador2;
        Jugador jugadorGanador;
        Baraja baraja;
        Stack<ICarta> pozoDeDescarte;
        int manosJugadas;
        EEstadosPartidas estadoPartida;
        StringBuilder sbMensajeJuego;
        StringBuilder sbMensajeCartasEnMesa;
        public delegate void EventoUI(string x,ICarta b);
        public event EventoUI EventoModificarUI;
        int cantidadMasCuatroUsados;
        int cantidadMasDosUsados;
        int cantidadBloqueoReversa;


        public Partida(Jugador jugador1, Jugador jugador2)
        {
            this.sbMensajeJuego = new StringBuilder();
            this.sbMensajeCartasEnMesa = new StringBuilder();
            this.jugador1 = jugador1;
            this.jugador2 = jugador2;
            this.baraja = new Baraja();
            this.baraja.barajaUnoMezclada = Sistema.Baraja.CopiarMezclarBaraja(Sistema.Baraja.barajaUno);
            jugador1.ManoCartasJugador = baraja.RepartirCartasAJugador(7);
            jugador2.ManoCartasJugador = baraja.RepartirCartasAJugador(7);
            this.pozoDeDescarte = new Stack<ICarta>();
            pozoDeDescarte.Push(baraja.DarCarta());
            this.manosJugadas = 0;
            this.estadoPartida = EEstadosPartidas.Jugando;
            this.cantidadMasCuatroUsados = 0;
            this.cantidadMasDosUsados = 0;
            this.cantidadBloqueoReversa = 0;
        }

        public ICarta CartaEnMesa { get => pozoDeDescarte.Peek();}

        public string CantarUno
        {
            get
            {
                if (jugador1.CartasRestantes==1)
                {
                    return $"{jugador1.NombreUsuario} CANTA UNO{Environment.NewLine}";
                }
                else if(jugador2.CartasRestantes==1)
                    return $"{jugador2.NombreUsuario} CANTA UNO{Environment.NewLine}";

                return "";

            }
        }

        public Jugador JugadorGanador { get => jugadorGanador; set => jugadorGanador = value; }
        public Jugador Jugador1 { get => jugador1; set => jugador1 = value; }
        public Jugador Jugador2 { get => jugador2; set => jugador2 = value; }
        public StringBuilder SbMensajeJuego { get => sbMensajeJuego; set => sbMensajeJuego = value; }
        public EEstadosPartidas EstadoPartida { get => estadoPartida; set => estadoPartida = value; }
        public StringBuilder SbMensajeCartasEnMesa { get => sbMensajeCartasEnMesa; set => sbMensajeCartasEnMesa = value; }
        public int CantidadMasCuatroUsados { get => cantidadMasCuatroUsados;  }
        public int CantidadMasDosUsados { get => cantidadMasDosUsados;  }
        public int CantidadBloqueoReversa { get => cantidadBloqueoReversa;}
        public int ManosJugadas { get => manosJugadas;}
        public Baraja Baraja { get => baraja; set => baraja = value; }

        public string InicioDelJuego()
        {
            sbMensajeJuego.AppendLine("Bienvenidos al Juego de UNO");
            sbMensajeJuego.AppendLine("Repartiendo 7 cartas a cada jugador...\n");
            do
            {
                pozoDeDescarte.Push(baraja.DarCarta());
            } while (!pozoDeDescarte.Peek().PuedeSerPrimerCarta);
            return sbMensajeJuego.AppendLine($"La carta en mesa es {CartaEnMesa}").ToString();
        }

        public string DeclararGanador()
        {
            EstadoPartida = EEstadosPartidas.Finalizado;
                if (jugador1.CartasRestantes < jugador2.CartasRestantes)
                {
                    JugadorGanador = jugador1;
                    return $"El ganador es {jugadorGanador.NombreUsuario} con {jugadorGanador.CartasRestantes} cartas restantes.";
                }
                else if (jugador1.CartasRestantes > jugador2.CartasRestantes)
                {
                    JugadorGanador = jugador2;
                    return $"El ganador es {jugadorGanador.NombreUsuario} con {jugadorGanador.CartasRestantes} cartas restantes.";
                }
                else
                {
                    return "El juego finalizo en empate";
                }
        }

        public void JugarMano()
        {
            int casoDeJuego = -1;
            int cantidadVecesTomarCarta = 0;
            ICarta cartaAJugar;
            Jugador jugadorMano;
            Jugador jugadorContrario;
            bool juegaOtraVez = false;
            sbMensajeCartasEnMesa.Append($"{CartaEnMesa}{Environment.NewLine}");
            if (EventoModificarUI is not null)
            {
                EventoModificarUI(sbMensajeJuego.ToString(), CartaEnMesa);
                Task.Delay(500).Wait();
            }


            if (manosJugadas%2==0)
            {
                jugadorMano = jugador1;
                jugadorContrario = jugador2;
            }
            else
            {
                jugadorMano = jugador2;
                jugadorContrario = jugador1;
            }

            //VA POR TURNOS
            do
            {
                Task.Delay(500).Wait();
                juegaOtraVez = false;
                EvaluarCasoAJugar(jugadorMano, out casoDeJuego, out cartaAJugar);
                sbMensajeJuego.Append(Jugar(casoDeJuego, jugadorMano, jugadorContrario, cartaAJugar,out juegaOtraVez));
                
                //ROMPO BUCLE PARA QUE SOLO LEVANTE UNA CARTA Y PASE TURNO AL NO PODER JGUAR
                if (cantidadVecesTomarCarta >= 1 && casoDeJuego==-1)
                {
                    sbMensajeJuego.AppendLine("PASO TURNO");
                    break;
                }

                //TOMA CARTA EN CASO -1, QUE NO PUEDE JUGAR
                if (casoDeJuego == -1)
                {  
                    juegaOtraVez = true;
                    cantidadVecesTomarCarta++;
                    sbMensajeJuego.Append(TomarCarta(jugadorMano));
                }

                if (CantarUno != String.Empty)
                    sbMensajeJuego.Append(CantarUno);
                //EVENTO 
                if(EventoModificarUI is not null)
                    EventoModificarUI(sbMensajeJuego.ToString(),CartaEnMesa);

            } while (juegaOtraVez);
            manosJugadas++;
        }

      



        private void EvaluarCasoAJugar(Jugador jugador,out int caso,out ICarta cartaAJugar)
        {
            cartaAJugar=null;
            caso = -1;
            foreach (ICarta item in jugador.ManoCartasJugador)
            {
                //AMBOS NUMERICOS
                if(item is CartaNumerica && CartaEnMesa is CartaNumerica)
                {
                    if(((CartaNumerica)CartaEnMesa).Equals(item))
                    {
                        cartaAJugar = item;
                        caso = 1;
                        break;
                    }
                }

                if(item is CartaAccion && CartaEnMesa is CartaAccion)
                {
                    if (((CartaAccion)CartaEnMesa).Equals(item))
                    {
                        cartaAJugar = item;
                        caso = 2;
                        break;
                    }
                }

                //TIRO NUMERO CON MISMO COLOR DE ACCION
                if (item is CartaNumerica && CartaEnMesa is CartaAccion)
                {
                    if (((CartaAccion)CartaEnMesa).ColorCarta == ((CartaNumerica)item).ColorCarta || 
                        ((CartaAccion)CartaEnMesa).ColorCarta==EColores.Negro)
                    {
                        cartaAJugar = item;
                        caso =3;
                        break;
                    }
                }

                if (item is CartaAccion && CartaEnMesa is CartaNumerica)
                {
                    if (((CartaNumerica)CartaEnMesa).ColorCarta == ((CartaAccion)item).ColorCarta)
                    {
                        cartaAJugar = item;
                        caso = 2;
                        break;
                    }
                }
                if (item is CartaAccion)
                    if (((CartaAccion)item).EsMasCuatro)
                    {
                        cartaAJugar = item;
                        caso = 2;
                        break;
                    }

                if(item is CartaComodin)
                {
                    cartaAJugar = item;
                    caso = 4;
                    break;
                }

                if (item is CartaNumerica && CartaEnMesa is CartaComodin)
                {
                    if (((CartaComodin)CartaEnMesa).ColorElegido == ((CartaNumerica)item).ColorCarta)
                    {
                        cartaAJugar = item;
                        caso = 1;
                        break;
                    }
                }
                if (item is CartaAccion && CartaEnMesa is CartaComodin)
                {
                    if (((CartaComodin)CartaEnMesa).ColorElegido == ((CartaAccion)item).ColorCarta)
                    {
                        cartaAJugar = item;
                        caso = 2;
                        break;
                    }
                }

            }
        }


        public string Jugar (int caso,Jugador jugador, Jugador jugadorContrario,ICarta carta,out bool tiraOtraVez)
        {
            tiraOtraVez=false;
            StringBuilder sbMensaje = new StringBuilder();
            switch (caso)
            {
                case 1: //AMBOS NUMERICOS
                    sbMensaje = JugarCarta(jugador, carta);
                    return sbMensaje.ToString();
                
                case 2: //AMBOS CARTAS DE ACCION O TIRO ACCION MISMO COLOR QUENUMERO
                    sbMensaje = JugarCarta(jugador, carta);

                    if (((CartaAccion)carta).EsReversa || ((CartaAccion)carta).EsSaltaTurno)
                    {
                        cantidadBloqueoReversa++;
                        sbMensaje.AppendLine($"{jugadorContrario.NombreUsuario} bloqueado, {jugador.NombreUsuario} vuelve a tirar");
                        tiraOtraVez = true;
                    }

                    if (((CartaAccion)carta).EsMasDos)
                    {
                        jugadorContrario.TomarCarta = baraja.DarCarta();
                        jugadorContrario.TomarCarta = baraja.DarCarta();
                        cantidadMasDosUsados++;
                        sbMensaje.AppendLine($"{jugadorContrario.NombreUsuario} levanta 2 cartas");
                    }
                    
                    if (((CartaAccion)carta).EsMasCuatro)
                    {
                        jugadorContrario.TomarCarta = baraja.DarCarta();
                        jugadorContrario.TomarCarta = baraja.DarCarta();
                        jugadorContrario.TomarCarta = baraja.DarCarta();
                        jugadorContrario.TomarCarta = baraja.DarCarta();
                        cantidadMasCuatroUsados++;
                        sbMensaje.AppendLine($"{jugadorContrario.NombreUsuario} levanta 4 cartas");
                    }

                    return sbMensaje.ToString();

                case 3: //TIRO NUMERO CON MISMO COLOR DE ACCION/
                    sbMensaje = JugarCarta(jugador, carta);
                    return sbMensaje.ToString();

                case 4:
                    sbMensaje = JugarCarta(jugador, carta);
                    if (carta is CartaComodin)
                    {
                        ((CartaComodin)carta).ColorElegido = jugador.ElegirColorComodin();
                        sbMensaje.AppendLine($"\nEl color elegido es {((CartaComodin)carta).ColorElegido}");

                    }

                    return sbMensaje.ToString();

                case -1:
                    break;
                default:
                    break;
            }
            return null;
        }


        public string TomarCarta(Jugador jugadorMano)
        {
            if (jugadorMano is not null)
            {
                StringBuilder sbMensaje = new StringBuilder();
                jugadorMano.TomarCarta = baraja.DarCarta();
                sbMensaje.AppendLine($"{jugadorMano.NombreUsuario} toma {jugadorMano.ManoCartasJugador.Last()}");
                return sbMensaje.ToString();
            }
            else
                throw new ArgumentNullException("Error en modulo partida, param. jugadorMano es nulo");

           
        }

        public StringBuilder JugarCarta(Jugador jugador, ICarta item)
        {
            if (jugador is not null && item is not null)
            {
                jugador.ManoCartasJugador.Remove(item);
                pozoDeDescarte.Push(item);
                StringBuilder sbMensaje = new StringBuilder();
                return sbMensaje.AppendLine($"{jugador.NombreUsuario} juega {pozoDeDescarte.Peek()}");
            }
            else
                throw new ArgumentNullException("Error en modulo partida, param. jugar carta nulo");

            
        }


    }
}
