using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Uno.Test
{
    [TestClass]
    public class BarajaShould
    {


        [TestMethod]
        public void DarCartaCorrectamenteIsNotNull()
        {
            Baraja baraja = new Baraja();
            baraja.barajaUnoMezclada = Sistema.Baraja.CopiarMezclarBaraja(Sistema.Baraja.barajaUno);
            ICarta carta;
            int cartasRestantes = baraja.CantidadCartasRestantes;
            carta = baraja.DarCarta();
            
            Assert.IsNotNull(carta);
        }
        [TestMethod]
        public void DarCartaCorrectamenteDisminuyoCantidadCartas()
        {

            Baraja baraja = new Baraja();
            baraja.barajaUnoMezclada = Sistema.Baraja.CopiarMezclarBaraja(Sistema.Baraja.barajaUno);
            ICarta carta;
            int cartasRestantes = baraja.CantidadCartasRestantes;
            carta = baraja.DarCarta();

            Assert.IsTrue(cartasRestantes > baraja.CantidadCartasRestantes);
        }
        
        [TestMethod]
        public void RepartirCartasCorrectamenteCantidad7()
        {
            Baraja baraja = new Baraja();
            baraja.barajaUnoMezclada = Sistema.Baraja.CopiarMezclarBaraja(Sistema.Baraja.barajaUno);
            List<ICarta> listaPrueba = baraja.RepartirCartasAJugador(7);

            Assert.IsTrue(listaPrueba.Count == 7);
        }

        [TestMethod]
        public void RepartirCartasCorrectamenteIsNotNull()
        {
            Baraja baraja = new Baraja();
            baraja.barajaUnoMezclada = Sistema.Baraja.CopiarMezclarBaraja(Sistema.Baraja.barajaUno);
            List<ICarta> listaPrueba = baraja.RepartirCartasAJugador(7);

            Assert.IsNotNull(listaPrueba);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void RepartirCartasCorrectamenteLanzarExcepcionCantidad()
        {
            Baraja baraja = new Baraja();
            baraja.barajaUnoMezclada = Sistema.Baraja.CopiarMezclarBaraja(Sistema.Baraja.barajaUno);
            List<ICarta> listaPrueba = baraja.RepartirCartasAJugador(0);
        }


        [TestMethod]
        public void CopiarMezclarBarajaDeberia()
        {
            Baraja baraja = new Baraja();
            baraja.barajaUnoMezclada = Sistema.Baraja.CopiarMezclarBaraja(Sistema.Baraja.barajaUno);

            Assert.IsNotNull(baraja.barajaUnoMezclada);
        }

        [TestMethod]
        public void CopiarMezclarBarajaDeberiaContenerCartas()
        {
            Baraja baraja = new Baraja();
            baraja.barajaUnoMezclada = Sistema.Baraja.CopiarMezclarBaraja(Sistema.Baraja.barajaUno);

            Assert.IsNotNull(baraja.barajaUnoMezclada.Count>0);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CopiarMezclarBarajaDeberiaLanzarExcepcion()
        {
            Baraja baraja = new Baraja();
            baraja.barajaUnoMezclada = Sistema.Baraja.CopiarMezclarBaraja(null);
        }
    }
}
