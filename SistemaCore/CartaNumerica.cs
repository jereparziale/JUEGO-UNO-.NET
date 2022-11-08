using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCore
{

    public class CartaNumerica: ICarta
    {
        int numeroValor;
        EColores colorCarta;

        public CartaNumerica(int numeroValor, EColores colorCarta)
        {
            this.numeroValor = numeroValor;
            this.colorCarta = colorCarta;
        }

        public int NumeroValor { get => numeroValor; }
        public EColores ColorCarta { get => colorCarta;  }

        public bool PuedeSerPrimerCarta
        {
            get
            {
                return true;
            }
        }
        public override string ToString()
        {
            return $"Carta {this.numeroValor} {this.colorCarta.ToString()}";
        }

        public override bool Equals(object obj)
        {
            CartaNumerica carta = obj as CartaNumerica;
            return carta is not null && EsCartaNumerica(carta, this);
        }

        private bool EsCartaNumerica(CartaNumerica a, CartaNumerica b)
        {
            return a.NumeroValor == b.NumeroValor || a.ColorCarta == b.ColorCarta;
        }
    }
}
