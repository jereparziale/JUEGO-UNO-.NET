using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCore
{
    public class CartaAccion: ICarta
    {
        EColores colorCarta;
        bool esReversa;
        bool esSaltaTurno;
        bool esMasDos;
        bool esMasCuatro;
        int cartasALevantar;

        public CartaAccion()
        {
            this.colorCarta = ColorCarta;
            this.esReversa = EsReversa;
            this.esSaltaTurno = EsSaltaTurno;
            this.esMasCuatro = EsMasCuatro;
            this.esMasDos = EsMasDos;
            if (!esReversa || !EsSaltaTurno)
                this.cartasALevantar = 0;
            else if (esMasDos)
                this.cartasALevantar = 2;
            else if (esMasCuatro)
                this.cartasALevantar = 4;
        }
        public CartaAccion(EColores colorCarta, bool esReversa, bool esSaltaTurno, bool esMasDos, bool esMasCuatro)
        {
            this.colorCarta = colorCarta;
            this.esReversa = esReversa;
            this.esSaltaTurno = esSaltaTurno;
            this.esMasCuatro = esMasCuatro;
            this.esMasDos = esMasDos;
            if (!esReversa || !EsSaltaTurno)
                this.cartasALevantar = 0;
            else if (esMasDos)
                this.cartasALevantar = 2;
            else if (esMasCuatro)
                this.cartasALevantar = 4;
        }

   

        

        public bool PuedeSerPrimerCarta
        {
            get
            {
                return false;
            }
        }

        public EColores ColorCarta { get => colorCarta; set => colorCarta = value; }
        public bool EsReversa { get => esReversa; set => esReversa = value; }
        public bool EsSaltaTurno { get => esSaltaTurno; set => esSaltaTurno = value; }
        public bool EsMasDos { get => esMasDos; set => esMasDos = value; }
        public bool EsMasCuatro { get => esMasCuatro; set => esMasCuatro = value; }
        public int CartasALevantar { get => cartasALevantar; set => cartasALevantar = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (this.esReversa)
                sb.Append("Carta Reversa");
            
            if (this.esSaltaTurno)
                sb.Append("Carta Salta turno");
            
            if (this.esMasDos)
                sb.Append("Carta mas dos");
            
            if(this.esMasCuatro)
                sb.Append("Carta mas cuatro");

            sb.Append($" {this.colorCarta.ToString()}");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            CartaAccion carta = obj as CartaAccion;
            return carta is not null && EsCartaAccion(carta, this);
        }

        private bool EsCartaAccion(CartaAccion a, CartaAccion b)
        {
            if(a.ColorCarta==b.ColorCarta)
            {
                return (a.esReversa == true == b.esReversa == true || a.esSaltaTurno == true == b.esSaltaTurno == true || a.esMasDos == true == b.esMasDos == true);
            }
            return false;
            
        }
    }
}
