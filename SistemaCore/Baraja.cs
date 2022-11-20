using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SistemaCore
{
    public class Baraja
    {
        [JsonIgnore]
        public List<ICarta> barajaUno;
        [JsonIgnore]
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

        public Baraja(bool leerJson)
        {
            listaCartasAccion = new List<CartaAccion>();
            listaCartasNumericas = new List<CartaNumerica>();
            listaCartasComodin = new List<CartaComodin>();
        }

        

        public List<CartaNumerica> ListaCartasNumericas { get => listaCartasNumericas; set => listaCartasNumericas = value; }
        public List<CartaAccion> ListaCartasAccion { get => listaCartasAccion; set => listaCartasAccion = value; }
        public List<CartaComodin> ListaCartasComodin { get => listaCartasComodin; set => listaCartasComodin = value; }

        [JsonIgnore]
        public int CantidadCartasRestantes { get => barajaUnoMezclada.Count;}

        public ICarta DarCarta()
        {
            if (CantidadCartasRestantes > 0)
                return barajaUnoMezclada.Pop();
            else
                throw new Exception("No hay mas cartas para entregar");
        }
        


        public List<ICarta> RepartirCartasAJugador(int cantidad)
        {
            if (cantidad > 0)
            {
                List<ICarta> manoCartasJugador = new List<ICarta>();
                for (int i = 0; i < cantidad; i++)
                {
                    manoCartasJugador.Add(this.barajaUnoMezclada.Pop());
                }
                return manoCartasJugador;
            }
            else
                throw new Exception("Error en modulo 'baraja', cantidad no valida");


            
        }

        public Stack<ICarta> CopiarMezclarBaraja(List<ICarta> baraja)
        {
            if (baraja is not null)
            {
                Random rnd = new Random();
                List<ICarta> barajaMezclada = baraja.OrderBy(item => rnd.Next()).ToList();
                Stack<ICarta> stackAux = new Stack<ICarta>(barajaMezclada);
                return stackAux;
            }
            else
                throw new ArgumentNullException("Error en modulo 'baraja'");
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
            listaCartasNumericas.Add(new CartaNumerica(0, EColores.Azul, "../../../assets/0azul.png"));
            listaCartasNumericas.Add(new CartaNumerica(1, EColores.Azul, "../../../assets/0azul.png"));
            listaCartasNumericas.Add(new CartaNumerica(2, EColores.Azul, "../../../assets/0azul.png"));
            listaCartasNumericas.Add(new CartaNumerica(3, EColores.Azul, "../../../assets/0azul.png"));
            listaCartasNumericas.Add(new CartaNumerica(4, EColores.Azul, "../../../assets/0azul.png"));
            listaCartasNumericas.Add(new CartaNumerica(5, EColores.Azul, "../../../assets/0azul.png"));
            listaCartasNumericas.Add(new CartaNumerica(6, EColores.Azul, "../../../assets/0azul.png"));
            listaCartasNumericas.Add(new CartaNumerica(7, EColores.Azul, "../../../assets/0azul.png"));
            listaCartasNumericas.Add(new CartaNumerica(8, EColores.Azul, "../../../assets/0azul.png"));
            listaCartasNumericas.Add(new CartaNumerica(9, EColores.Azul, "../../../assets/0azul.png"));
            listaCartasNumericas.Add(new CartaNumerica(1, EColores.Azul, "../../../assets/0azul.png"));
            listaCartasNumericas.Add(new CartaNumerica(2, EColores.Azul, "../../../assets/0azul.png"));
            listaCartasNumericas.Add(new CartaNumerica(3, EColores.Azul, "../../../assets/0azul.png"));
            listaCartasNumericas.Add(new CartaNumerica(4, EColores.Azul, "../../../assets/0azul.png"));
            listaCartasNumericas.Add(new CartaNumerica(5, EColores.Azul, "../../../assets/0azul.png"));
            listaCartasNumericas.Add(new CartaNumerica(6, EColores.Azul, "../../../assets/0azul.png"));
            listaCartasNumericas.Add(new CartaNumerica(7, EColores.Azul, "../../../assets/0azul.png"));
            listaCartasNumericas.Add(new CartaNumerica(8, EColores.Azul, "../../../assets/0azul.png"));
            listaCartasNumericas.Add(new CartaNumerica(9, EColores.Azul, "../../../assets/0azul.png"));
            listaCartasAccion.Add(new CartaAccion(EColores.Azul, true, false, false, false, "../../../assets/reversaAzul.png"));
            listaCartasAccion.Add(new CartaAccion(EColores.Azul, false, true, false, false, "../../../assets/bloqueoAzul.png"));
            listaCartasAccion.Add(new CartaAccion(EColores.Azul, false, false, true, false, "../../../assets/masDosAzul.png"));
            listaCartasAccion.Add(new CartaAccion(EColores.Azul, false, false, true, false, "../../../assets/masDosAzul.png"));
            #endregion
            #region CARTAS ROJAS
            listaCartasNumericas.Add(new CartaNumerica(0, EColores.Rojo, "../../../assets/0rojo.png"));
            listaCartasNumericas.Add(new CartaNumerica(1, EColores.Rojo,"../../../assets/0rojo.png"));
            listaCartasNumericas.Add(new CartaNumerica(2, EColores.Rojo,"../../../assets/0rojo.png"));
            listaCartasNumericas.Add(new CartaNumerica(3, EColores.Rojo,"../../../assets/0rojo.png"));
            listaCartasNumericas.Add(new CartaNumerica(4, EColores.Rojo,"../../../assets/0rojo.png"));
            listaCartasNumericas.Add(new CartaNumerica(5, EColores.Rojo,"../../../assets/0rojo.png"));
            listaCartasNumericas.Add(new CartaNumerica(6, EColores.Rojo,"../../../assets/0rojo.png"));
            listaCartasNumericas.Add(new CartaNumerica(7, EColores.Rojo,"../../../assets/0rojo.png"));
            listaCartasNumericas.Add(new CartaNumerica(8, EColores.Rojo,"../../../assets/0rojo.png"));
            listaCartasNumericas.Add(new CartaNumerica(9, EColores.Rojo,"../../../assets/0rojo.png"));
            listaCartasNumericas.Add(new CartaNumerica(1, EColores.Rojo,"../../../assets/0rojo.png"));
            listaCartasNumericas.Add(new CartaNumerica(2, EColores.Rojo,"../../../assets/0rojo.png"));
            listaCartasNumericas.Add(new CartaNumerica(3, EColores.Rojo,"../../../assets/0rojo.png"));
            listaCartasNumericas.Add(new CartaNumerica(4, EColores.Rojo,"../../../assets/0rojo.png"));
            listaCartasNumericas.Add(new CartaNumerica(5, EColores.Rojo,"../../../assets/0rojo.png"));
            listaCartasNumericas.Add(new CartaNumerica(6, EColores.Rojo,"../../../assets/0rojo.png"));
            listaCartasNumericas.Add(new CartaNumerica(7, EColores.Rojo,"../../../assets/0rojo.png"));
            listaCartasNumericas.Add(new CartaNumerica(8, EColores.Rojo,"../../../assets/0rojo.png"));
            listaCartasNumericas.Add(new CartaNumerica(9, EColores.Rojo, "../../../assets/0rojo.png"));
            listaCartasAccion.Add(new CartaAccion(EColores.Rojo, true, false, false, false, "../../../assets/reversaRojo.png"));
            listaCartasAccion.Add(new CartaAccion(EColores.Rojo, false, true, false, false, "../../../assets/bloqueoRojo.png"));
            listaCartasAccion.Add(new CartaAccion(EColores.Rojo, false, false, true, false, "../../../assets/masDosRojo.png"));
            listaCartasAccion.Add(new CartaAccion(EColores.Rojo, false, false, true, false, "../../../assets/masDosRojo.png"));
            #endregion
            #region CARTAS AMARILLAS
            listaCartasNumericas.Add(new CartaNumerica(0, EColores.Amarillo, "../../../assets/0amarillo.png"));
            listaCartasNumericas.Add(new CartaNumerica(1, EColores.Amarillo, "../../../assets/0amarillo.png"));
            listaCartasNumericas.Add(new CartaNumerica(2, EColores.Amarillo, "../../../assets/0amarillo.png"));
            listaCartasNumericas.Add(new CartaNumerica(3, EColores.Amarillo, "../../../assets/0amarillo.png"));
            listaCartasNumericas.Add(new CartaNumerica(4, EColores.Amarillo, "../../../assets/0amarillo.png"));
            listaCartasNumericas.Add(new CartaNumerica(5, EColores.Amarillo, "../../../assets/0amarillo.png"));
            listaCartasNumericas.Add(new CartaNumerica(6, EColores.Amarillo, "../../../assets/0amarillo.png"));
            listaCartasNumericas.Add(new CartaNumerica(7, EColores.Amarillo, "../../../assets/0amarillo.png"));
            listaCartasNumericas.Add(new CartaNumerica(8, EColores.Amarillo, "../../../assets/0amarillo.png"));
            listaCartasNumericas.Add(new CartaNumerica(9, EColores.Amarillo, "../../../assets/0amarillo.png"));
            listaCartasNumericas.Add(new CartaNumerica(1, EColores.Amarillo, "../../../assets/0amarillo.png"));
            listaCartasNumericas.Add(new CartaNumerica(2, EColores.Amarillo, "../../../assets/0amarillo.png"));
            listaCartasNumericas.Add(new CartaNumerica(3, EColores.Amarillo, "../../../assets/0amarillo.png"));
            listaCartasNumericas.Add(new CartaNumerica(4, EColores.Amarillo, "../../../assets/0amarillo.png"));
            listaCartasNumericas.Add(new CartaNumerica(5, EColores.Amarillo, "../../../assets/0amarillo.png"));
            listaCartasNumericas.Add(new CartaNumerica(6, EColores.Amarillo, "../../../assets/0amarillo.png"));
            listaCartasNumericas.Add(new CartaNumerica(7, EColores.Amarillo, "../../../assets/0amarillo.png"));
            listaCartasNumericas.Add(new CartaNumerica(8, EColores.Amarillo, "../../../assets/0amarillo.png"));
            listaCartasNumericas.Add(new CartaNumerica(9, EColores.Amarillo, "../../../assets/0amarillo.png"));
            listaCartasAccion.Add(new CartaAccion(EColores.Amarillo, true, false, false, false, "../../../assets/reversaAmarillo.png"));
            listaCartasAccion.Add(new CartaAccion(EColores.Amarillo, false, true, false, false, "../../../assets/bloqueoAmarillo.png"));
            listaCartasAccion.Add(new CartaAccion(EColores.Amarillo, false, false, true, false, "../../../assets/masDosAmarillo.png"));
            listaCartasAccion.Add(new CartaAccion(EColores.Amarillo, false, false, true, false, "../../../assets/masDosAmarillo.png"));
            #endregion
            #region CARTAS VERDES
            listaCartasNumericas.Add(new CartaNumerica(0, EColores.Verde, "../../../assets/0verde.png"));
            listaCartasNumericas.Add(new CartaNumerica(1, EColores.Verde, "../../../assets/0verde.png"));
            listaCartasNumericas.Add(new CartaNumerica(2, EColores.Verde, "../../../assets/0verde.png"));
            listaCartasNumericas.Add(new CartaNumerica(3, EColores.Verde, "../../../assets/0verde.png"));
            listaCartasNumericas.Add(new CartaNumerica(4, EColores.Verde, "../../../assets/0verde.png"));
            listaCartasNumericas.Add(new CartaNumerica(5, EColores.Verde, "../../../assets/0verde.png"));
            listaCartasNumericas.Add(new CartaNumerica(6, EColores.Verde, "../../../assets/0verde.png"));
            listaCartasNumericas.Add(new CartaNumerica(7, EColores.Verde, "../../../assets/0verde.png"));
            listaCartasNumericas.Add(new CartaNumerica(8, EColores.Verde, "../../../assets/0verde.png"));
            listaCartasNumericas.Add(new CartaNumerica(9, EColores.Verde, "../../../assets/0verde.png"));
            listaCartasNumericas.Add(new CartaNumerica(1, EColores.Verde, "../../../assets/0verde.png"));
            listaCartasNumericas.Add(new CartaNumerica(2, EColores.Verde, "../../../assets/0verde.png"));
            listaCartasNumericas.Add(new CartaNumerica(3, EColores.Verde, "../../../assets/0verde.png"));
            listaCartasNumericas.Add(new CartaNumerica(4, EColores.Verde, "../../../assets/0verde.png"));
            listaCartasNumericas.Add(new CartaNumerica(5, EColores.Verde, "../../../assets/0verde.png"));
            listaCartasNumericas.Add(new CartaNumerica(6, EColores.Verde, "../../../assets/0verde.png"));
            listaCartasNumericas.Add(new CartaNumerica(7, EColores.Verde, "../../../assets/0verde.png"));
            listaCartasNumericas.Add(new CartaNumerica(8, EColores.Verde, "../../../assets/0verde.png"));
            listaCartasNumericas.Add(new CartaNumerica(9, EColores.Verde, "../../../assets/0verde.png"));
            listaCartasAccion.Add(new CartaAccion(EColores.Verde, true, false, false, false, "../../../assets/reversaVerde.png"));
            listaCartasAccion.Add(new CartaAccion(EColores.Verde, false, true, false, false, "../../../assets/bloqueoVerde.png"));
            listaCartasAccion.Add(new CartaAccion(EColores.Verde, false, false, true, false, "../../../assets/masDosVerde.png"));
            listaCartasAccion.Add(new CartaAccion(EColores.Verde, false, false, true, false, "../../../assets/masDosVerde.png"));
            #endregion
            #region CARTAS NEGRAS
            CartaAccion masCuatro0 = new CartaAccion(EColores.Negro, false, false, false, true, "../../../assets/masCuatro.png");
            CartaAccion masCuatro1 = new CartaAccion(EColores.Negro, false, false, false, true, "../../../assets/masCuatro.png");
            CartaAccion masCuatro2 = new CartaAccion(EColores.Negro, false, false, false, true, "../../../assets/masCuatro.png");
            CartaAccion masCuatro3 = new CartaAccion(EColores.Negro, false, false, false, true, "../../../assets/masCuatro.png");
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
