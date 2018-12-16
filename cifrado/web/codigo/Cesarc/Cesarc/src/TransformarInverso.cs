using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cesarc.src
{
    public class TransformarInverso
    {
        public string inverso(string texto, string texto_inverso)
        {
            for (int i = texto.Length - 1; i >= 0; i--)
                texto_inverso += texto[i];
            return texto_inverso;
        }
    }
}