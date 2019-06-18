#include "Header.h"
WORD GetConsoleTextAttribute(HANDLE hCon)
{
	/*
	windows h rengler ucun istifade Olunan Funksiya
	*/
	CONSOLE_SCREEN_BUFFER_INFO con_info;
	GetConsoleScreenBufferInfo(hCon, &con_info);
	return con_info.wAttributes;
}
int main()
{
	Admin loding;
	loding.CHARRR();
	HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	const int saved_colors = GetConsoleTextAttribute(hConsole);
	
	int a;
	loding.GotoXY(50,9);
	SetConsoleTextAttribute(hConsole, FOREGROUND_GREEN | FOREGROUND_INTENSITY);
	cout << " Creat new User[1]";
	SetConsoleTextAttribute(hConsole, saved_colors);
	loding.GotoXY(50, 10);
	SetConsoleTextAttribute(hConsole, FOREGROUND_GREEN | FOREGROUND_INTENSITY);
	cout << "Login Admin Panel[2]";
	SetConsoleTextAttribute(hConsole, saved_colors);
	loding.GotoXY(50, 11);
	SetConsoleTextAttribute(hConsole, FOREGROUND_GREEN | FOREGROUND_INTENSITY);
	cout << "Enter a Valve : "; 
	SetConsoleTextAttribute(hConsole, saved_colors);
	SetConsoleTextAttribute(hConsole, 241);
	cin >> a;
	SetConsoleTextAttribute(hConsole, saved_colors);
	cin.ignore();
	system("cls");

	if (a == 1)
	{
		//crat user;

	}
	if (a == 2)
	{
		if (loding.Login()) {
			while (true)
			{
				loding.GotoXY(50, 9);
				cout << "Chance Admin Login Pass[1]";
				cin >> a;

				if (a == 1)
				{
					//Chance Admin Login Pass
					system("cls");
					loding.change();
					system("cls");
				}
			}
		}
	}
	system("pause");
	return 0;
}
