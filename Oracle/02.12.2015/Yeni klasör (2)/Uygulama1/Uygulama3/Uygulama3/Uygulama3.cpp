// Uygulama3.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include  <time.h>

using namespace std; 


void _tmain(int argc, _TCHAR* argv[])
{
	short int dizi[7];
	srand(time(NULL));
	for (int i = 0; i < 7; i++){
		dizi[1] = rand() % 100;
		cout << dizi[i] << "\t";
	}

	system("Pause");
}

