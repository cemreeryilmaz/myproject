// Ornek_6.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{
	int say�;
	cout << "bir sayi giriniz : ";
	cin >> say�;

	if (say� % 2 == 0)
	{
		cout << "cift" << endl;
	}
	else
	{
		cout << "tek" << endl;
	}

	system("pause");
	return 0;
}

