#pragma once
#include <iostream>
#include "TransformarInverso.h"
using namespace std;

class GruposInversos:public TransformarInverso
{
public:
	string invertir_en_grupos(string mensaje, int elementos_en_elgrupo, string nuevo_mensaje);
private:
	string mover(string mensaje, int inicio, int fin, string mensajenuevo);
};

