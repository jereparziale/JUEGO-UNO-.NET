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
        string pathImagenCarta;

        public CartaNumerica()
        {
            this.numeroValor = NumeroValor;
            this.colorCarta = ColorCarta;
            this.pathImagenCarta = PathImagenCarta;
        }
        public CartaNumerica(int numeroValor, EColores colorCarta,string pathImagenCarta)
        {
            this.numeroValor = numeroValor;
            this.colorCarta = colorCarta;
            this.pathImagenCarta = pathImagenCarta;
        }

        public string PathImagenCarta
        {
            get
            {
                return pathImagenCarta;
            }
            set
            {
                pathImagenCarta = value;
            }
        }

        public bool PuedeSerPrimerCarta
        {
            get
            {
                return true;
            }
        }

        public int NumeroValor { get => numeroValor; set => numeroValor = value; }
        public EColores ColorCarta { get => colorCarta; set => colorCarta = value; }

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
