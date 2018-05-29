// Ornek_4.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{
	int sayý;
	cout << "bir sayi giriniz : ";
	cin >> sayý;

	if (sayý > 50)
	{
		cout << "sayi 50'den buyuktur..." << endl;
	}
	cout << "girilen sayi = " << sayý << endl;

	system("pause");
	return 0;
}

