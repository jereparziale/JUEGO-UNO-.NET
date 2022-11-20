using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCore
{
    public class CartaComodin:ICarta
    {
        EColores colorElegido;
        string pathImagenCarta;

        public CartaComodin()
        {
            this.colorElegido = EColores.Negro;
            this.pathImagenCarta = "../../../assets/comodin.png";
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
                return false;
            }
        }

        public EColores ColorElegido { get => colorElegido; set => colorElegido = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Carta Comodin ");
            if (this.colorElegido!=EColores.Negro)
                sb.Append($"color {this.colorElegido.ToString()}");
            else
                sb.Append("sin color elegido");

            return sb.ToString();
        }
    }
}
