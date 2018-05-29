// Ornek_6.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{
	int sayý;
	cout << "bir sayi giriniz : ";
	cin >> sayý;

	if (sayý % 2 == 0)
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

