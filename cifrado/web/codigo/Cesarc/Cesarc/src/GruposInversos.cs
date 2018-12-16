using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cesarc.src
{
    public class GruposInversos
    {
        TransformarInverso ti = new TransformarInverso();
        public string invertir_en_grupos(string mensaje, int elementos_en_elgrupo, string nuevo_mensaje)
        {
            int inicio_grupo = 0;

            if (elementos_en_elgrupo < 1)
                return mensaje;

            for (int i = 0; i < mensaje.Length; i++)
            {
                if ((i + 1) % elementos_en_elgrupo == 0)
                {
                    nuevo_mensaje = nuevo_mensaje.Substring(0, inicio_grupo);
                    nuevo_mensaje += mover(mensaje, inicio_grupo, i + 1, "");
                    inicio_grupo += elementos_en_elgrupo;
                }
                else
                {
                    nuevo_mensaje += mensaje[i];
                }
            }
            return nuevo_mensaje;
        }

        private string mover(string mensaje, int inicio, int fin, string mensajenuevo)
        {
            for (int i = inicio; i < fin; i++)
            {
                mensajenuevo += mensaje[i];
            }
            return ti.inverso(mensajenuevo, "");
        }

    }
}