#include "CifradoLetra.h"

char CifradoLetra::letraCifrada(char letra, int desplazamiento, int suma, int posicion){
	suma = posicion + desplazamiento;
	if (suma < 0)
		suma = alfabeto_spanish().size() + suma;
	else if (suma > alfabeto_spanish().size())
		suma= suma - alfabeto_spanish().size();
	
	return alfabeto_spanish()[suma];
}
