// Ornek_4.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{
	int say�;
	cout << "bir sayi giriniz : ";
	cin >> say�;

	if (say� > 50)
	{
		cout << "sayi 50'den buyuktur..." << endl;
	}
	cout << "girilen sayi = " << say� << endl;

	system("pause");
	return 0;
}

