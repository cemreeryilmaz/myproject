// Uygulama2.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

using namespace std;


void _tmain(int argc, _TCHAR* argv[])
{
	char karakterdizisi[] = { 'a', 'b', 'c', 'd', 'e' };  //statik atama
	for (int i = 0; i < 5; i++){
		cout << karakterdizisi[i] << "\t";
	}
	system("pause");
}

