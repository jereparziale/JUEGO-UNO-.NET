using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCore
{
    public class Baraja
    {
        Stack<ICarta> barajaUno;

        public Baraja()
        {
            this.barajaUno = new Stack<ICarta>();
            CrearBaraja();
        }

        public Stack<ICarta> BarajaUno { get => barajaUno;}
        public int CantidadCartasRestantes { get => barajaUno.Count;}

        public ICarta DarCarta()
        {
            if (CantidadCartasRestantes > 0)
                return barajaUno.Pop();
            else
                throw new Exception("No hay mas cartas para entregar");
        }
        


        public List<ICarta> RepartirCartasAJugador(int cantidad)
        {
            List<ICarta> manoCartasJugador = new List<ICarta>();
            for (int i = 0; i < cantidad; i++)
            {
                manoCartasJugador.Add(this.BarajaUno.Pop());
            }
            return manoCartasJugador;
        }


        private void CrearBaraja()
        {
            List<ICarta> barajalista;
            List<ICarta> barajaOrdenada;
            barajalista=CrearCartas();
            barajaOrdenada=MezclarBaraja(barajalista);
            foreach (ICarta item in barajaOrdenada)
            {
                this.barajaUno.Push(item);
            }
        }

        private List<ICarta> CrearCartas()
        {
            List<ICarta> nuevaBaraja = new List<ICarta>();
            #region CARTAS AZULES
            CartaNumerica cartaAzul0 = new CartaNumerica(0,EColores.Azul);
            CartaNumerica cartaAzul1 = new CartaNumerica(1,EColores.Azul);
            CartaNumerica cartaAzul2 = new CartaNumerica(2,EColores.Azul);
            CartaNumerica cartaAzul3 = new CartaNumerica(3,EColores.Azul);
            CartaNumerica cartaAzul4 = new CartaNumerica(4,EColores.Azul);
            CartaNumerica cartaAzul5 = new CartaNumerica(5,EColores.Azul);
            CartaNumerica cartaAzul6 = new CartaNumerica(6,EColores.Azul);
            CartaNumerica cartaAzul7 = new CartaNumerica(7,EColores.Azul);
            CartaNumerica cartaAzul8 = new CartaNumerica(8,EColores.Azul);
            CartaNumerica cartaAzul9 = new CartaNumerica(9,EColores.Azul);
            CartaAccion cartaReversaAzul = new CartaAccion(EColores.Azul, true, false,false,false);
            CartaAccion cartaSaltaTurnoAzul= new CartaAccion(EColores.Azul, false, true,false,false);
            CartaAccion cartaMasDosAzul0 = new CartaAccion(EColores.Azul, false, false, true, false);
            CartaAccion cartaMasDosAzul1 = new CartaAccion(EColores.Azul, false, false, true, false);
            nuevaBaraja.Add(cartaAzul0);
            nuevaBaraja.Add(cartaAzul1);
            nuevaBaraja.Add(cartaAzul2);
            nuevaBaraja.Add(cartaAzul3);
            nuevaBaraja.Add(cartaAzul4);
            nuevaBaraja.Add(cartaAzul5);
            nuevaBaraja.Add(cartaAzul6);
            nuevaBaraja.Add(cartaAzul7);
            nuevaBaraja.Add(cartaAzul8);
            nuevaBaraja.Add(cartaAzul9);
            nuevaBaraja.Add(cartaReversaAzul);
            nuevaBaraja.Add(cartaSaltaTurnoAzul);
            nuevaBaraja.Add(cartaMasDosAzul0);
            nuevaBaraja.Add(cartaMasDosAzul1);
            #endregion
            #region CARTAS ROJAS
            CartaNumerica cartarojo0 = new CartaNumerica(0, EColores.Rojo);
            CartaNumerica cartarojo1 = new CartaNumerica(1, EColores.Rojo);
            CartaNumerica cartarojo2 = new CartaNumerica(2, EColores.Rojo);
            CartaNumerica cartarojo3 = new CartaNumerica(3, EColores.Rojo);
            CartaNumerica cartarojo4 = new CartaNumerica(4, EColores.Rojo);
            CartaNumerica cartarojo5 = new CartaNumerica(5, EColores.Rojo);
            CartaNumerica cartarojo6 = new CartaNumerica(6, EColores.Rojo);
            CartaNumerica cartarojo7 = new CartaNumerica(7, EColores.Rojo);
            CartaNumerica cartarojo8 = new CartaNumerica(8, EColores.Rojo);
            CartaNumerica cartarojo9 = new CartaNumerica(9, EColores.Rojo);
            CartaAccion cartaReversarojo = new CartaAccion(EColores.Rojo, true, false,false,false);
            CartaAccion cartaSaltaTurnorojo = new CartaAccion(EColores.Rojo, false, true, false, false);
            CartaAccion cartaMasDosRojo0 = new CartaAccion(EColores.Rojo, false, false, true, false);
            CartaAccion cartaMasDosRojo1 = new CartaAccion(EColores.Rojo, false, false, true, false);
            nuevaBaraja.Add(cartarojo0);
            nuevaBaraja.Add(cartarojo1);
            nuevaBaraja.Add(cartarojo2);
            nuevaBaraja.Add(cartarojo3);
            nuevaBaraja.Add(cartarojo4);
            nuevaBaraja.Add(cartarojo5);
            nuevaBaraja.Add(cartarojo6);
            nuevaBaraja.Add(cartarojo7);
            nuevaBaraja.Add(cartarojo8);
            nuevaBaraja.Add(cartarojo9);
            nuevaBaraja.Add(cartaReversarojo);
            nuevaBaraja.Add(cartaSaltaTurnorojo);
            nuevaBaraja.Add(cartaMasDosRojo0);
            nuevaBaraja.Add(cartaMasDosRojo1);
            #endregion
            #region CARTAS AMARILLAS
            CartaNumerica cartaAmarillo0 = new CartaNumerica(0, EColores.Amarillo);
            CartaNumerica cartaAmarillo1 = new CartaNumerica(1, EColores.Amarillo);
            CartaNumerica cartaAmarillo2 = new CartaNumerica(2, EColores.Amarillo);
            CartaNumerica cartaAmarillo3 = new CartaNumerica(3, EColores.Amarillo);
            CartaNumerica cartaAmarillo4 = new CartaNumerica(4, EColores.Amarillo);
            CartaNumerica cartaAmarillo5 = new CartaNumerica(5, EColores.Amarillo);
            CartaNumerica cartaAmarillo6 = new CartaNumerica(6, EColores.Amarillo);
            CartaNumerica cartaAmarillo7 = new CartaNumerica(7, EColores.Amarillo);
            CartaNumerica cartaAmarillo8 = new CartaNumerica(8, EColores.Amarillo);
            CartaNumerica cartaAmarillo9 = new CartaNumerica(9, EColores.Amarillo);
            CartaAccion cartaReversaAmarillo = new CartaAccion(EColores.Amarillo, true, false, false, false);
            CartaAccion cartaSaltaTurnoAmarillo = new CartaAccion(EColores.Amarillo, false, true, false, false);
            CartaAccion cartaMasDosAmarillo0 = new CartaAccion(EColores.Amarillo ,false, false, true, false);
            CartaAccion cartaMasDosAmarillo1 = new CartaAccion(EColores.Amarillo, false, false, true, false);
            nuevaBaraja.Add(cartaAmarillo0);
            nuevaBaraja.Add(cartaAmarillo1);
            nuevaBaraja.Add(cartaAmarillo2);
            nuevaBaraja.Add(cartaAmarillo3);
            nuevaBaraja.Add(cartaAmarillo4);
            nuevaBaraja.Add(cartaAmarillo5);
            nuevaBaraja.Add(cartaAmarillo6);
            nuevaBaraja.Add(cartaAmarillo7);
            nuevaBaraja.Add(cartaAmarillo8);
            nuevaBaraja.Add(cartaAmarillo9);
            nuevaBaraja.Add(cartaReversaAmarillo);
            nuevaBaraja.Add(cartaSaltaTurnoAmarillo);
            nuevaBaraja.Add(cartaMasDosAmarillo0);
            nuevaBaraja.Add(cartaMasDosAmarillo1);
            #endregion
            #region CARTAS VERDES
            CartaNumerica cartaVerde0 = new CartaNumerica(0, EColores.Verde);
            CartaNumerica cartaVerde1 = new CartaNumerica(1, EColores.Verde);
            CartaNumerica cartaVerde2 = new CartaNumerica(2, EColores.Verde);
            CartaNumerica cartaVerde3 = new CartaNumerica(3, EColores.Verde);
            CartaNumerica cartaVerde4 = new CartaNumerica(4, EColores.Verde);
            CartaNumerica cartaVerde5 = new CartaNumerica(5, EColores.Verde);
            CartaNumerica cartaVerde6 = new CartaNumerica(6, EColores.Verde);
            CartaNumerica cartaVerde7 = new CartaNumerica(7, EColores.Verde);
            CartaNumerica cartaVerde8 = new CartaNumerica(8, EColores.Verde);
            CartaNumerica cartaVerde9 = new CartaNumerica(9, EColores.Verde);
            CartaAccion cartaReversaVerde = new CartaAccion(EColores.Verde, true, false, false, false);
            CartaAccion cartaSaltaTurnoVerde = new CartaAccion(EColores.Verde, false, true, false, false);
            CartaAccion cartaMasDosVerde0 = new CartaAccion(EColores.Verde, false, false, true, false);
            CartaAccion cartaMasDosVerde1 = new CartaAccion(EColores.Verde, false, false, true, false);
            nuevaBaraja.Add(cartaVerde0);
            nuevaBaraja.Add(cartaVerde1);
            nuevaBaraja.Add(cartaVerde2);
            nuevaBaraja.Add(cartaVerde3);
            nuevaBaraja.Add(cartaVerde4);
            nuevaBaraja.Add(cartaVerde5);
            nuevaBaraja.Add(cartaVerde6);
            nuevaBaraja.Add(cartaVerde7);
            nuevaBaraja.Add(cartaVerde8);
            nuevaBaraja.Add(cartaVerde9);
            nuevaBaraja.Add(cartaReversaVerde);
            nuevaBaraja.Add(cartaSaltaTurnoVerde);
            nuevaBaraja.Add(cartaMasDosVerde0);
            nuevaBaraja.Add(cartaMasDosVerde1);
            #endregion
            #region CARTAS NEGRAS
            CartaAccion masCuatro0 = new CartaAccion(EColores.Negro, false, false, false, true);
            CartaAccion masCuatro1 = new CartaAccion(EColores.Negro, false, false, false, true);
            CartaAccion masCuatro2 = new CartaAccion(EColores.Negro, false, false, false, true);
            CartaAccion masCuatro3 = new CartaAccion(EColores.Negro, false, false, false, true);
            nuevaBaraja.Add(masCuatro0);
            nuevaBaraja.Add(masCuatro1);
            nuevaBaraja.Add(masCuatro2);
            nuevaBaraja.Add(masCuatro3);
            CartaComodin comodin0 = new CartaComodin();
            CartaComodin comodin1 = new CartaComodin();
            CartaComodin comodin2 = new CartaComodin();
            CartaComodin comodin3 = new CartaComodin();
            nuevaBaraja.Add(comodin0);
            nuevaBaraja.Add(comodin1);
            nuevaBaraja.Add(comodin2);
            nuevaBaraja.Add(comodin3);
            #endregion

            return nuevaBaraja; 
        }

        private List<ICarta> MezclarBaraja(List<ICarta> baraja)
        {
            Random rnd = new Random();
            List<ICarta> barajaMezclada = baraja.OrderBy(item => rnd.Next()).ToList();
            return barajaMezclada;
        }


    }
}
