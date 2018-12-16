using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCesar
{
    class Alfabeto
    {
        private ArrayList alfabeto = new ArrayList();

        public Alfabeto() {
            alfabeto.Add('a'); alfabeto.Add('b'); alfabeto.Add('c'); alfabeto.Add('d'); alfabeto.Add('e'); alfabeto.Add('é');
            alfabeto.Add('f'); alfabeto.Add('g'); alfabeto.Add('h'); alfabeto.Add('i'); alfabeto.Add('í'); alfabeto.Add('j');
            alfabeto.Add('k'); alfabeto.Add('l'); alfabeto.Add('m'); alfabeto.Add('n'); alfabeto.Add('ñ'); alfabeto.Add('o');
            alfabeto.Add('ó'); alfabeto.Add('p'); alfabeto.Add('q'); alfabeto.Add('r'); alfabeto.Add('s'); alfabeto.Add('t');
            alfabeto.Add('u'); alfabeto.Add('v'); alfabeto.Add('w'); alfabeto.Add('x'); alfabeto.Add('y'); alfabeto.Add('z');
        }
        
        //private char[] alfabeto = { 'a','á','b','c','d','e','é','f','g','h','i','í','k','l','m','n','ñ','o','ó','p','q','r','s','t','u','v','w','x','y','z'  };

        public char getCaracter( int posicion ) {
            return (char)alfabeto[ (posicion % alfabeto.Count) ];
        }

        public bool contains( char caracter ) {
            return alfabeto.Contains( caracter );
        }

        public int posicion(char caracter) {
           return  alfabeto.IndexOf(caracter);
        }
    }
}
