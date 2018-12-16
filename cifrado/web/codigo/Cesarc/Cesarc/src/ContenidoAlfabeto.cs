using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cesarc.src
{
    public class ContenidoAlfabeto
    {
        Alfabeto alfa = new Alfabeto();

        public int posicionEn_elAlfabeto(char letra)
        {
            for (int i = 0; i < alfa.alfabeto_spanish().Length; i++)
            {
                if (letra == alfa.alfabeto_spanish()[i])
                    return i;
            }
            return -1;
        }
    }
}