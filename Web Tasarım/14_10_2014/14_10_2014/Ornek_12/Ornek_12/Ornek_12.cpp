// Ornek_12.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{
	int renk_kod;

	cout << "Lacivert icin....[1]" << endl <<
		"Morcivert icin...[2]" << endl <<
		"Kirmizi icin.....[3]" << endl <<
		"Yesil icin.......[4]" << endl <<
		endl <<
		"Renk kodu giriniz : ";
	cin >> renk_kod;

	switch (renk_kod)
	{
	case 1:
		cout << "Lacivert'i sectiniz..." << endl;
		break;

	case 2:
		cout << "Morcivert'i sectiniz..." << endl;
		break;

	case 3:
		cout << "Kirmizi'yi sectiniz..." << endl;
		break;

	case 4:
		cout << "Yesil'i sectiniz..." << endl;
		break;

	default:
		cout << "Yanlis Renk Kodu Sectiniz!!!" << endl;
		break;
	}

	system("pause");
	return 0;
}

