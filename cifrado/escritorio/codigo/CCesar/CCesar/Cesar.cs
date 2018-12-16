using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCesar
{
    class Cesar 
    {
        private int desplazamiento;
        private String texto;
        private Alfabeto alfabeto;

        public Cesar(String texto, int desplazamiento) {
            this.texto = texto;
            this.desplazamiento = desplazamiento;
            this.alfabeto = new Alfabeto();
        }

        public String Cifrar() {
            String salida = "";
            foreach (char caracter in texto)
                if (alfabeto.contains(caracter))
                    salida += alfabeto.getCaracter(alfabeto.posicion(caracter) + desplazamiento);
                else
                    salida += caracter;
            
            return salida;
        }

    }
}
