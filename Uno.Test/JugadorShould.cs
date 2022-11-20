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
    public class JugadorShould
    {
        [TestMethod]
        public void ElegirColorCorrectamenteIsNotNulkl()
        {
            Jugador jugador  = new Jugador(1,"prueba");
            Assert.IsNotNull(jugador.ElegirColorComodin());
        }

        [TestMethod]
        public void ElegirColorCorrectamenteEsTipoEnum()
        {
            Jugador jugador  = new Jugador(1,"prueba");
            Assert.IsInstanceOfType(jugador.ElegirColorComodin(),typeof(EColores));
        }
    }
}
