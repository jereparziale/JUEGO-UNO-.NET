﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCore
{
    public interface ICarta
    {
        public bool PuedeSerPrimerCarta
        {
            get;
            
        }

        public string PathImagenCarta
        {
            get;
            set;
        }
    }
}
