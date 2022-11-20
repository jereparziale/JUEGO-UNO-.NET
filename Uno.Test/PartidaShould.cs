using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno.Test
{
    [TestClass]
    public class PartidaShould
    {
        [TestMethod]
        public void InicioDelJuegoDeberiaIsNotNull()
        {
            Jugador J1 = new Jugador(1, "prueba");
            Jugador J2 = new Jugador(2, "prueba");
            Partida partida = new Partida(J1, J2);
            partida.InicioDelJuego();
            Assert.IsNotNull(partida.SbMensajeJuego);
        }

        [TestMethod]
        public void DeclararGanadorDeberiaFinalizarPartida()
        {
            Jugador J1 = new Jugador(1, "prueba");
            Jugador J2 = new Jugador(2, "prueba");
            Partida partida = new Partida(J1, J2);
            partida.DeclararGanador();

            Assert.AreEqual(partida.EstadoPartida, SistemaCore.EEstadosPartidas.Finalizado);
        }
        
        [TestMethod]
        public void DeclararGanadorDeberia()
        {
            Jugador J1 = new Jugador(1, "prueba");
            Jugador J2 = new Jugador(2, "prueba");
            Partida partida = new Partida(J1, J2);
            partida.JugarCarta(J1, partida.Baraja.DarCarta());// AL JUGAR UNA CARTA J1 DEBE SER GANADOR
            partida.DeclararGanador();

            Assert.AreEqual(J1,partida.JugadorGanador);
        }
        
        [TestMethod]
        public void DeclararGanadorDeberiaSerNuloPorEmpate()
        {
            Jugador J1 = new Jugador(1, "prueba");
            Jugador J2 = new Jugador(2, "prueba");
            Partida partida = new Partida(J1, J2);
            partida.DeclararGanador();
            //DEBE SER EMPATE, JUGADOR GANADOR ES NULL
            Assert.IsNull(partida.JugadorGanador);
        }

        [TestMethod]
        public void JugarCartaDeberiaDescontarCartaDeManoJugador()
        {
            Jugador J1 = new Jugador(1, "prueba");
            Jugador J2 = new Jugador(2, "prueba");
            Partida partida = new Partida(J1, J2);
            int cartasRestantesAnterior = J1.CartasRestantes;
            partida.JugarCarta(J1, partida.Baraja.DarCarta());

            Assert.IsTrue(cartasRestantesAnterior > J1.CartasRestantes);
        }
        
        [TestMethod]
        public void JugarCartaDeberiaRetonarSbNoNulo()
        {
            Jugador J1 = new Jugador(1, "prueba");
            Jugador J2 = new Jugador(2, "prueba");
            Partida partida = new Partida(J1, J2);

            Assert.IsNotNull(partida.JugarCarta(J1, partida.Baraja.DarCarta()));
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void JugarCartaDeberiaLanzarArgumentNullExcepcion()
        {
            Jugador J1 = new Jugador(1, "prueba");
            Jugador J2 = new Jugador(2, "prueba");
            Partida partida = new Partida(J1, J2);

            partida.JugarCarta(null, partida.Baraja.DarCarta());
        }
        
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TomarCartaDeberiaLanzarArgumentNullExcepcion()
        {
            Jugador J1 = new Jugador(1, "prueba");
            Jugador J2 = new Jugador(2, "prueba");
            Partida partida = new Partida(J1, J2);

            partida.TomarCarta(null);
        } 
        
        [TestMethod]
        public void TomarCartaDeberiaAumentarCartasEnManoEnUno()
        {
            Jugador J1 = new Jugador(1, "prueba");
            Jugador J2 = new Jugador(2, "prueba");
            Partida partida = new Partida(J1, J2);
            int cartasRestantesAnterior = J1.CartasRestantes;
            partida.TomarCarta(J1);
            Assert.IsTrue(cartasRestantesAnterior < J1.CartasRestantes);
        }

    }
}
