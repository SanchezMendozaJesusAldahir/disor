#include "TransformarInverso.h"


string TransformarInverso::inverso(string texto, string texto_inverso)
{
	for (int i = texto.size() - 1; i >= 0; i--)
		texto_inverso += texto[i];
	return texto_inverso;
}
