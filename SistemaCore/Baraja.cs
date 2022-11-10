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
        public List<ICarta> barajaUno;
        public Stack<ICarta> barajaUnoMezclada;
        List<CartaNumerica> listaCartasNumericas;
        List<CartaAccion> listaCartasAccion;
        List<CartaComodin> listaCartasComodin;


        public Baraja()
        {
            listaCartasAccion = new List<CartaAccion>();
            listaCartasNumericas = new List<CartaNumerica>();
            listaCartasComodin = new List<CartaComodin>();
            barajaUno = new List<ICarta>();
            barajaUnoMezclada = new Stack<ICarta>();
            
        }

        

        public List<CartaNumerica> ListaCartasNumericas { get => listaCartasNumericas; set => listaCartasNumericas = value; }
        public List<CartaAccion> ListaCartasAccion { get => listaCartasAccion; set => listaCartasAccion = value; }
        public List<CartaComodin> ListaCartasComodin { get => listaCartasComodin; set => listaCartasComodin = value; }
        private int CantidadCartasRestantes { get => barajaUnoMezclada.Count;}

        public ICarta DarCarta()
        {
            if (CantidadCartasRestantes > 0)
                return barajaUnoMezclada.Pop();
            else
                throw new Exception("No hay mas cartas para entregar");
        }
        


        public List<ICarta> RepartirCartasAJugador(int cantidad)
        {
            List<ICarta> manoCartasJugador = new List<ICarta>();
            for (int i = 0; i < cantidad; i++)
            {
                manoCartasJugador.Add(this.barajaUnoMezclada.Pop());
            }
            return manoCartasJugador;
        }

        public Stack<ICarta> CopiarMezclarBaraja(List<ICarta> baraja)
        {
            Random rnd = new Random();
            List<ICarta> barajaMezclada = baraja.OrderBy(item => rnd.Next()).ToList();
            Stack<ICarta> stackAux = new Stack<ICarta>(barajaMezclada);
            return stackAux;
        }


        public void LlenarListaICarta()
        {
            foreach (CartaAccion item in listaCartasAccion)
            {
                barajaUno.Add(item);
            }
            foreach (CartaNumerica item in listaCartasNumericas)
            {
                barajaUno.Add(item);
            }
            foreach (CartaComodin item in listaCartasComodin)
            {
                barajaUno.Add(item);
            }
        }


        ///NO USAR!!!!!!!!!!!!!!!!!!!!!
        private void CrearCartas()
        {
            #region CARTAS AZULES
            listaCartasNumericas.Add(new CartaNumerica(0, EColores.Azul));
            listaCartasNumericas.Add(new CartaNumerica(1, EColores.Azul));
            listaCartasNumericas.Add(new CartaNumerica(2, EColores.Azul));
            listaCartasNumericas.Add(new CartaNumerica(3, EColores.Azul));
            listaCartasNumericas.Add(new CartaNumerica(4, EColores.Azul));
            listaCartasNumericas.Add(new CartaNumerica(5, EColores.Azul));
            listaCartasNumericas.Add(new CartaNumerica(6, EColores.Azul));
            listaCartasNumericas.Add(new CartaNumerica(7, EColores.Azul));
            listaCartasNumericas.Add(new CartaNumerica(8, EColores.Azul));
            listaCartasNumericas.Add(new CartaNumerica(9, EColores.Azul));
            listaCartasNumericas.Add(new CartaNumerica(1, EColores.Azul));
            listaCartasNumericas.Add(new CartaNumerica(2, EColores.Azul));
            listaCartasNumericas.Add(new CartaNumerica(3, EColores.Azul));
            listaCartasNumericas.Add(new CartaNumerica(4, EColores.Azul));
            listaCartasNumericas.Add(new CartaNumerica(5, EColores.Azul));
            listaCartasNumericas.Add(new CartaNumerica(6, EColores.Azul));
            listaCartasNumericas.Add(new CartaNumerica(7, EColores.Azul));
            listaCartasNumericas.Add(new CartaNumerica(8, EColores.Azul));
            listaCartasNumericas.Add(new CartaNumerica(9, EColores.Azul));
            listaCartasAccion.Add(new CartaAccion(EColores.Azul, true, false, false, false));
            listaCartasAccion.Add(new CartaAccion(EColores.Azul, false, true, false, false));
            listaCartasAccion.Add(new CartaAccion(EColores.Azul, false, false, true, false));
            listaCartasAccion.Add(new CartaAccion(EColores.Azul, false, false, true, false));
            #endregion
            #region CARTAS ROJAS
            listaCartasNumericas.Add(new CartaNumerica(0, EColores.Rojo));
            listaCartasNumericas.Add(new CartaNumerica(1, EColores.Rojo));
            listaCartasNumericas.Add(new CartaNumerica(2, EColores.Rojo));
            listaCartasNumericas.Add(new CartaNumerica(3, EColores.Rojo));
            listaCartasNumericas.Add(new CartaNumerica(4, EColores.Rojo));
            listaCartasNumericas.Add(new CartaNumerica(5, EColores.Rojo));
            listaCartasNumericas.Add(new CartaNumerica(6, EColores.Rojo));
            listaCartasNumericas.Add(new CartaNumerica(7, EColores.Rojo));
            listaCartasNumericas.Add(new CartaNumerica(8, EColores.Rojo));
            listaCartasNumericas.Add(new CartaNumerica(9, EColores.Rojo));
            listaCartasNumericas.Add(new CartaNumerica(1, EColores.Rojo));
            listaCartasNumericas.Add(new CartaNumerica(2, EColores.Rojo));
            listaCartasNumericas.Add(new CartaNumerica(3, EColores.Rojo));
            listaCartasNumericas.Add(new CartaNumerica(4, EColores.Rojo));
            listaCartasNumericas.Add(new CartaNumerica(5, EColores.Rojo));
            listaCartasNumericas.Add(new CartaNumerica(6, EColores.Rojo));
            listaCartasNumericas.Add(new CartaNumerica(7, EColores.Rojo));
            listaCartasNumericas.Add(new CartaNumerica(8, EColores.Rojo));
            listaCartasNumericas.Add(new CartaNumerica(9, EColores.Rojo));
            CartaAccion cartaReversarojo = new CartaAccion(EColores.Rojo, true, false, false, false);
            CartaAccion cartaSaltaTurnorojo = new CartaAccion(EColores.Rojo, false, true, false, false);
            CartaAccion cartaMasDosRojo0 = new CartaAccion(EColores.Rojo, false, false, true, false);
            CartaAccion cartaMasDosRojo1 = new CartaAccion(EColores.Rojo, false, false, true, false);
            listaCartasAccion.Add(cartaReversarojo);
            listaCartasAccion.Add(cartaSaltaTurnorojo);
            listaCartasAccion.Add(cartaMasDosRojo0);
            listaCartasAccion.Add(cartaMasDosRojo1);
            #endregion
            #region CARTAS AMARILLAS
            listaCartasNumericas.Add(new CartaNumerica(0, EColores.Amarillo));
            listaCartasNumericas.Add(new CartaNumerica(1, EColores.Amarillo));
            listaCartasNumericas.Add(new CartaNumerica(2, EColores.Amarillo));
            listaCartasNumericas.Add(new CartaNumerica(3, EColores.Amarillo));
            listaCartasNumericas.Add(new CartaNumerica(4, EColores.Amarillo));
            listaCartasNumericas.Add(new CartaNumerica(5, EColores.Amarillo));
            listaCartasNumericas.Add(new CartaNumerica(6, EColores.Amarillo));
            listaCartasNumericas.Add(new CartaNumerica(7, EColores.Amarillo));
            listaCartasNumericas.Add(new CartaNumerica(8, EColores.Amarillo));
            listaCartasNumericas.Add(new CartaNumerica(9, EColores.Amarillo));
            listaCartasNumericas.Add(new CartaNumerica(1, EColores.Amarillo));
            listaCartasNumericas.Add(new CartaNumerica(2, EColores.Amarillo));
            listaCartasNumericas.Add(new CartaNumerica(3, EColores.Amarillo));
            listaCartasNumericas.Add(new CartaNumerica(4, EColores.Amarillo));
            listaCartasNumericas.Add(new CartaNumerica(5, EColores.Amarillo));
            listaCartasNumericas.Add(new CartaNumerica(6, EColores.Amarillo));
            listaCartasNumericas.Add(new CartaNumerica(7, EColores.Amarillo));
            listaCartasNumericas.Add(new CartaNumerica(8, EColores.Amarillo));
            listaCartasNumericas.Add(new CartaNumerica(9, EColores.Amarillo));
            CartaAccion cartaReversaAmarillo = new CartaAccion(EColores.Amarillo, true, false, false, false);
            CartaAccion cartaSaltaTurnoAmarillo = new CartaAccion(EColores.Amarillo, false, true, false, false);
            CartaAccion cartaMasDosAmarillo0 = new CartaAccion(EColores.Amarillo, false, false, true, false);
            CartaAccion cartaMasDosAmarillo1 = new CartaAccion(EColores.Amarillo, false, false, true, false);
            listaCartasAccion.Add(cartaReversaAmarillo);
            listaCartasAccion.Add(cartaSaltaTurnoAmarillo);
            listaCartasAccion.Add(cartaMasDosAmarillo0);
            listaCartasAccion.Add(cartaMasDosAmarillo1);
            #endregion
            #region CARTAS VERDES
            listaCartasNumericas.Add(new CartaNumerica(0, EColores.Verde));
            listaCartasNumericas.Add(new CartaNumerica(1, EColores.Verde));
            listaCartasNumericas.Add(new CartaNumerica(2, EColores.Verde));
            listaCartasNumericas.Add(new CartaNumerica(3, EColores.Verde));
            listaCartasNumericas.Add(new CartaNumerica(4, EColores.Verde));
            listaCartasNumericas.Add(new CartaNumerica(5, EColores.Verde));
            listaCartasNumericas.Add(new CartaNumerica(6, EColores.Verde));
            listaCartasNumericas.Add(new CartaNumerica(7, EColores.Verde));
            listaCartasNumericas.Add(new CartaNumerica(8, EColores.Verde));
            listaCartasNumericas.Add(new CartaNumerica(9, EColores.Verde));
            listaCartasNumericas.Add(new CartaNumerica(1, EColores.Verde));
            listaCartasNumericas.Add(new CartaNumerica(2, EColores.Verde));
            listaCartasNumericas.Add(new CartaNumerica(3, EColores.Verde));
            listaCartasNumericas.Add(new CartaNumerica(4, EColores.Verde));
            listaCartasNumericas.Add(new CartaNumerica(5, EColores.Verde));
            listaCartasNumericas.Add(new CartaNumerica(6, EColores.Verde));
            listaCartasNumericas.Add(new CartaNumerica(7, EColores.Verde));
            listaCartasNumericas.Add(new CartaNumerica(8, EColores.Verde));
            listaCartasNumericas.Add(new CartaNumerica(9, EColores.Verde));
            CartaAccion cartaReversaVerde = new CartaAccion(EColores.Verde, true, false, false, false);
            CartaAccion cartaSaltaTurnoVerde = new CartaAccion(EColores.Verde, false, true, false, false);
            CartaAccion cartaMasDosVerde0 = new CartaAccion(EColores.Verde, false, false, true, false);
            CartaAccion cartaMasDosVerde1 = new CartaAccion(EColores.Verde, false, false, true, false);
            listaCartasAccion.Add(cartaReversaVerde);
            listaCartasAccion.Add(cartaSaltaTurnoVerde);
            listaCartasAccion.Add(cartaMasDosVerde0);
            listaCartasAccion.Add(cartaMasDosVerde1);
            #endregion
            #region CARTAS NEGRAS
            CartaAccion masCuatro0 = new CartaAccion(EColores.Negro, false, false, false, true);
            CartaAccion masCuatro1 = new CartaAccion(EColores.Negro, false, false, false, true);
            CartaAccion masCuatro2 = new CartaAccion(EColores.Negro, false, false, false, true);
            CartaAccion masCuatro3 = new CartaAccion(EColores.Negro, false, false, false, true);
            listaCartasAccion.Add(masCuatro0);
            listaCartasAccion.Add(masCuatro1);
            listaCartasAccion.Add(masCuatro2);
            listaCartasAccion.Add(masCuatro3);
            CartaComodin comodin0 = new CartaComodin();
            CartaComodin comodin1 = new CartaComodin();
            CartaComodin comodin2 = new CartaComodin();
            CartaComodin comodin3 = new CartaComodin();
            listaCartasComodin.Add(comodin0);
            listaCartasComodin.Add(comodin1);
            listaCartasComodin.Add(comodin2);
            listaCartasComodin.Add(comodin3);
            #endregion
        }

    }
}
