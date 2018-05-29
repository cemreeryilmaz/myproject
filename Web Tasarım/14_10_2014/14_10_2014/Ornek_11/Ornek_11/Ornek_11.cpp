// Ornek_11.cpp : Defines the entry point for the console application.
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

	if (renk_kod == 1)
		cout << "Lacivert'i sectiniz..." << endl;
	else if (renk_kod == 2)
		cout << "Morcivert'i sectiniz..." << endl;
	else if (renk_kod == 3)
		cout << "Kirmizi'yi sectiniz..." << endl;
	else if (renk_kod == 4)
		cout << "Yesil'i sectiniz..." << endl;
	else
		cout << "Yanlis Renk Kodu Girdiniz!!!" << endl;

	system("pause");
	return 0;
}

