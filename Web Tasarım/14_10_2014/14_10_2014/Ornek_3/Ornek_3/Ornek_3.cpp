// Ornek_3.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{
	int a, b, top;

	cout << "a sayisini giriniz : ";
	cin >> a;

	cout << "b sayisini giriniz : ";
	cin >> b;

	top = a + b;

	cout << "Toplam = " << top << endl << endl;
	
	system("pause");
	return 0;
}

