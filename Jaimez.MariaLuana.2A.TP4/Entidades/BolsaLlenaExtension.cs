﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class BolsaLlenaExtension
    {
        public static string InformarNovedad(this BolsaLlenaException excepcion)
        {
            return excepcion.Message;
        }
    }
}
