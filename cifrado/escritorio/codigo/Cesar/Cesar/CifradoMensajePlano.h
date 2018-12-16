#include <iostream>
#include "CifradoLetra.h"

using namespace std;

class CifradoMensajePlano:public CifradoLetra
{
public:
	string mensajeCifrado(string textoPlano, int desplazamiento, string textoCifrado);
};

