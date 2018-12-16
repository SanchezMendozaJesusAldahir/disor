#include "GruposInversos.h"


string GruposInversos::invertir_en_grupos(string mensaje, int elementos_en_elgrupo, string nuevo_mensaje)
{
	int inicio_grupo = 0;

	if (elementos_en_elgrupo < 1)
		return mensaje;

	for (int i = 0; i < mensaje.size(); i++)
	{
		if ((i + 1) % elementos_en_elgrupo == 0)
		{
			nuevo_mensaje = nuevo_mensaje.substr(0, inicio_grupo);
			nuevo_mensaje += mover(mensaje, inicio_grupo, i + 1, "");
			inicio_grupo += elementos_en_elgrupo;
		}
		else {
			nuevo_mensaje += mensaje[i];
		}
	}
	return nuevo_mensaje;
}

string GruposInversos::mover(string mensaje, int inicio, int fin, string mensajenuevo)
{
	for (int i = inicio; i < fin; i++)
	{
		mensajenuevo += mensaje[i];
	}
	return inverso(mensajenuevo, "");
}
