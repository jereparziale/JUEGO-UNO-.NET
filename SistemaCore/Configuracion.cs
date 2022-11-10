using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCore
{
    public class Configuracion
    {
        int cantidadDeManos;
        bool declararPorPuntos;

        public Configuracion()
        {

        }

        public int CantidadDeManos { get => cantidadDeManos; set => cantidadDeManos = value; }
        public bool DeclararPorPuntos { get => declararPorPuntos; set => declararPorPuntos = value; }
    }
}
