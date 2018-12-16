#include "ContenidoAlfabeto.h"



int ContenidoAlfabeto::posicionEn_elAlfabeto(char letra) {
	for (int i = 0; i < alfabeto_spanish().size(); i++)
	{
		if (letra == alfabeto_spanish()[i])
			return i;
	}
	return -1;
}