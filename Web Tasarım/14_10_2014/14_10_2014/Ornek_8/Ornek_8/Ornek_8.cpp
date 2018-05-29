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
	int sayý;
	cout << "bir sayi giriniz : ";
	cin >> sayý;
	
	if (sayý < 0)
	{
		cout << "sayi 0'dan kucuk..." << endl;
	}
	else if (sayý >= 0 && sayý <= 25)
	{
		cout << "sayi 0-25 araliginda..." << endl;
	}
	else if (sayý >= 26 && sayý <= 50)
	{
		cout << "sayi 26-50 araliginda..." << endl;
	}
	else //if (sayý > 50)
	{
		cout << "sayi 50'den buyuk..." << endl;
	}

	system("pause");
	return 0;
}

