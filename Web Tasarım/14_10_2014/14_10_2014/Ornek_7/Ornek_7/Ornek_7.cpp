// Ornek_7.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{
	int a, b;
	cout << "a sayisini giriniz : ";
	cin >> a;

	cout << "b sayisini giriniz : ";
	cin >> b;

	if (a > b)
	{
		cout << "a>b'dir" << endl;
	}
	else if (b > a)
	{
		cout << "b>a'dir" << endl;
	}
	else
	{
		cout << "a=b'dir" << endl;
	}
	system("pause");
	return 0;
}

