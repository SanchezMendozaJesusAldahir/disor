using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cesarc.src
{
    public class CifradoLetra
    {
        Alfabeto al = new Alfabeto();
        public char letraCifrada(char letra, int desplazamiento, int suma, int posicion)
        {
            suma = posicion + desplazamiento;
            if (suma > al.alfabeto_spanish().Length - 1)
                return al.alfabeto_spanish()[suma - al.alfabeto_spanish().Length];
            else if (suma < 0)
                return al.alfabeto_spanish()[al.alfabeto_spanish().Length + suma];
            else
                return al.alfabeto_spanish()[suma];
        }
    }
}