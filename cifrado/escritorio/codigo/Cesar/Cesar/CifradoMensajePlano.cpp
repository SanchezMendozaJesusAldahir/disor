#include "CifradoMensajePlano.h"



string CifradoMensajePlano::mensajeCifrado(string textoPlano, int desplazamiento, string textoCifrado) {

	for (int i = 0; i < textoPlano.size(); i++)
	{
		if (posicionEn_elAlfabeto(textoPlano[i]) != (-1))
			textoCifrado += letraCifrada(textoPlano[i], desplazamiento, 0, posicionEn_elAlfabeto(textoPlano[i]));
		else
			textoCifrado += textoPlano[i];
	}
	return textoCifrado;
}
