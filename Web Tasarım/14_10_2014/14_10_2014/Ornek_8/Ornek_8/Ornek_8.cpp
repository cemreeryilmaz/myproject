// Ornek_8.cpp : Defines the entry point for the console application.
//

/*
<0
0-25
26-50
>50
*/
#include "stdafx.h"
#include <iostream>
using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{
	int say�;
	cout << "bir sayi giriniz : ";
	cin >> say�;
	
	if (say� < 0)
	{
		cout << "sayi 0'dan kucuk..." << endl;
	}
	else if (say� >= 0 && say� <= 25)
	{
		cout << "sayi 0-25 araliginda..." << endl;
	}
	else if (say� >= 26 && say� <= 50)
	{
		cout << "sayi 26-50 araliginda..." << endl;
	}
	else //if (say� > 50)
	{
		cout << "sayi 50'den buyuk..." << endl;
	}

	system("pause");
	return 0;
}

