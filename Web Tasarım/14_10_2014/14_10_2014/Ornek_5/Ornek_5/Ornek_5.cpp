// Ornek_5.cpp : Defines the entry point for the console application.
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
		cout << "girilen sayi 50'den buyuk..." << endl;
	}
	else
	{
		cout << "girilen sayi 50'den buyuk degil!!!" << endl;
	}

	cout << "girilen sayi = " << say� << endl;

	system("pause");

	return 0;
}

