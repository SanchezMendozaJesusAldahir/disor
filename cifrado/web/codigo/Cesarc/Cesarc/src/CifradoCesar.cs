using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cesarc.src
{
    public class CifradoCesar
    {
        CifradoLetra cl = new CifradoLetra();
        ContenidoAlfabeto ca = new ContenidoAlfabeto();

        public string mensajeCifrado(string textoPlano, int desplazamiento, string textoCifrado)
        {
            for (int i = 0; i < textoPlano.Length; i++)
            {
                if (ca.posicionEn_elAlfabeto(textoPlano[i]) != (-1))
                    textoCifrado += cl.letraCifrada(textoPlano[i], desplazamiento, 0, ca.posicionEn_elAlfabeto(textoPlano[i]));
                else
                    textoCifrado += textoPlano[i];
            }
            return textoCifrado;
        }
    }
}