// Ornek_10.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{
	int a, b, c;

	cout << "a sayisini giriniz : ";
	cin >> a;

	cout << "b sayisini giriniz : ";
	cin >> b;

	c = (a > b) ? a - b : (b > a) ? b - a : a + b;

	cout << "c = " << c << endl << endl;

	system("pause");
	return 0;
}

