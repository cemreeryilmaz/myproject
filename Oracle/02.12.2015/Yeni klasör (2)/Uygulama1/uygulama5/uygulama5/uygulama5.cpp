// uygulama5.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

using namespace std;

void _tmain(int argc, _TCHAR* argv[])
{
	int elemansayisi;
	cout << "Eleman Sayisini giriniz:";
	cin >> elemansayisi;
	double dizi =new double [elemansayisi];
	for (int i = 0; i < elemansayisi; i++){
		dizi[i] = i + 0.1;
	}
}

