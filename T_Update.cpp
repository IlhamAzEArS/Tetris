#include <iostream>
#include <stdlib.h>
#include <ctime>
#include <conio.h>
#include <Windows.h>
#define _UP 72
#define _DOWN 80
#define _LEFT 75
#define _RIGHT 77

class Tetris {
private:
	bool randm = true;
	int leavel1 = 0;
	int uLines = 0;
	int A[21][21];
	int OnIzleme[4][4];
	int blok[4][4] =
	{
		{ 0, 0, 0, 0 },
		{ 0, 0, 0, 0 },
		{ 0, 0, 0, 0 },
		{ 0, 0, 0, 0 }
	};
	int sonraki[4][4];
	int tetris[21][12];

	int y = 0;

	int x = 4;

	bool gameover = false;

	int GAMESPEED = 20000;


	int score = 0;
	int tetris_random[7][4][4] =
	{
		{
			{ 0, 1, 0, 0 },
			{ 0, 1, 0, 0 },
			{ 0, 1, 0, 0 },
			{ 0, 1, 0, 0 }
		},
		{
			{ 0, 0, 0, 0 },
			{ 0, 1, 1, 0 },
			{ 0, 1, 0, 0 },
			{ 0, 1, 0, 0 }
		},
		{
			{ 0, 0, 1, 0 },
			{ 0, 1, 1, 0 },
			{ 0, 1, 0, 0 },
			{ 0, 0, 0, 0 }
		},
		{
			{ 0, 1, 0, 0 },
			{ 0, 1, 1, 0 },
			{ 0, 0, 1, 0 },
			{ 0, 0, 0, 0 }
		},
		{
			{ 0, 0, 0, 0 },
			{ 0, 1, 0, 0 },
			{ 1, 1, 1, 0 },
			{ 0, 0, 0, 0 }
		},
		{
			{ 0, 0, 0, 0 },
			{ 0, 1, 1, 0 },
			{ 0, 1, 1, 0 },
			{ 0, 0, 0, 0 }
		},
		{
			{ 0, 0, 0, 0 },
			{ 0, 1, 1, 0 },
			{ 0, 0, 1, 0 },
			{ 0, 0, 1, 0 }
		}
	};
public:
	void GMOVER(std::string text);
	void CHARRR();
	void GotoXY(int, int);
	
	void SLR();
	void SearchLines();
	void Clear_line(int);
	int menu();
	void leavel();
	int gameOver();
	void title();
	void Deyisme();
	void gorunus();
	bool Get_Ranom_Figur();//ivaran cixmaqi engelliyir
	void Tetris_Iceri();
	void Sag_Sol_(int, int);
	void Tetris1();
	bool Tetris2(int, int);
	void tetrsi_istifadeci();
	bool Tetris_rota();
	void Tetris_1();
};
WORD GetConsoleTextAttribute(HANDLE hCon);
int main()
{
	Tetris tetris;
	tetris.CHARRR();
	switch (tetris.menu())
	{
	case 1:
		system("cls");
		tetris.Deyisme();
		break;
	case 2:
		return 0;
	case 0:
		std::cout << " 1~2" << std::endl;
		return -1;
	}

	return 0;
}
void Tetris::GMOVER(std::string text)
{
	for (int i = 0; text[i] != 0; i++)
	{
		Sleep(3);
		std::cout << text[i];
	}
}
int Tetris::gameOver()
{
	Sleep(10);

	Tetris tetris;

	tetris.GMOVER("   _____          __  __ ______    ______      ________ _____  _\n");
	tetris.GMOVER("  / ____|   /\   |  \/  |  ____|  / __ \ \    / /  ____|  __ \| | \n");
	tetris.GMOVER(" | |  __   /  \  | \  / | |__    | |  | \ \  / /| |__  | |__) | |\n");
	tetris.GMOVER(" | | |_ | / /\ \ | |\/| |  __|   | |  | |\ \/ / |  __| |  _  /| | \n");
	tetris.GMOVER(" | |__| |/ ____ \| |  | | |____  | |__| | \  /  | |____| | \ \|_|\n");
	tetris.GMOVER("  \_____/_/    \_\_|  |_|______|  \____/   \/   |______|_|  \_(_)\n");
	tetris.GMOVER(" ________________________________________________________________________ \n");
	tetris.GMOVER("|________________________________________________________________________|\n");

	return 0;
}

void Tetris::Deyisme()
{
	int time = 0;
	Tetris_Iceri();

	while (!gameover)
	{
		if (_kbhit())
		{
			tetrsi_istifadeci();
		}

		if (time < GAMESPEED)
		{
			time++;
		}
		else
		{
			Tetris_1();
			time = 0;
		}
	}

}

int Tetris::menu()
{
	title();

	int select_num = 0;

	std::cin >> select_num;

	switch (select_num)
	{
	case 1:
	case 2:
	case 3:
		break;
	default:
		select_num = 0;
		break;
	}

	return select_num;
}

void Tetris::title()
{


	GotoXY(10, 4);


	std::cout << "\t<menu>\n";

	std::cout << "\t1: Start Game\n\t2: Quit\n\n";

	std::cout << "#==============================================================================#\n";
	std::cout << " >> ";


}

void Tetris::gorunus()
{

	GotoXY(0, 0);


	HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	const int saved_colors = GetConsoleTextAttribute(hConsole);

	for (int i = 0; i < 21; i++)
	{
		for (int j = 0; j < 12; j++)
		{



			switch (tetris[i][j])
			{

			case 0:
				//WORD AS;
				SetConsoleTextAttribute(hConsole, 241);
				std::cout << " ";

				SetConsoleTextAttribute(hConsole, saved_colors);
				break;
			case 9:
				SetConsoleTextAttribute(hConsole, BACKGROUND_GREEN | BACKGROUND_INTENSITY);
				std::cout << " ";

				SetConsoleTextAttribute(hConsole, saved_colors);

				break;
			case 1:
				SetConsoleTextAttribute(hConsole, BACKGROUND_RED | FOREGROUND_INTENSITY);
				std::cout << " ";

				SetConsoleTextAttribute(hConsole, saved_colors);

				break;
			}

		}
		std::cout << std::endl;
	}


	SLR();

	if (gameover)
	{
		system("cls");
		gameOver();
	}
}

void Tetris::CHARRR()
{

	HANDLE out = GetStdHandle(STD_OUTPUT_HANDLE);
	CONSOLE_CURSOR_INFO  coursorInfo;
	GetConsoleCursorInfo(out, &coursorInfo);
	coursorInfo.bVisible = false;
	SetConsoleCursorInfo(out, &coursorInfo);
}
void Tetris::GotoXY(int x, int y) {
	/*
	Consulda Ekrana Cap Olunan Yazilarin Kordinatini Verilen Funksiya
	*/
	COORD c;
	c.X = y;
	c.Y = y;
	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), c);
}

void Tetris::SLR()
{
	HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	const int saved_colors = GetConsoleTextAttribute(hConsole);

	SetConsoleTextAttribute(hConsole, FOREGROUND_GREEN | COMMON_LVB_TRAILING_BYTE);
	GotoXY(3, 4);
	std::cout << "\t\t" << "Leavel : [" << leavel1 << "]";
	GotoXY(3, 5);
	std::cout << "\t\t" << "Score :  [" << score << "]";

	SetConsoleTextAttribute(hConsole, saved_colors);
	SetConsoleTextAttribute(hConsole, FOREGROUND_GREEN | FOREGROUND_INTENSITY);
	GotoXY(30, 23);
	std::cout << "\n\tA: left\tS: down\tD: right \t Rotation[Space]";
	SetConsoleTextAttribute(hConsole, saved_colors);


	GotoXY(0, 23);
	for (int i = 0; i < 4; i++) {

		for (int j = 0; j < 4; j++) {

			switch (sonraki[i][j])
			{

			case 0:

				std::cout << ' ';

				break;
			case 1:
				std::cout << ' ';

				break;
			}
		}


		std::cout << std::endl;
	}

}

WORD GetConsoleTextAttribute(HANDLE hCon)
{
	/*
	windows h rengler ucun istifade Olunan Funksiya
	*/
	CONSOLE_SCREEN_BUFFER_INFO con_info;
	GetConsoleScreenBufferInfo(hCon, &con_info);
	return con_info.wAttributes;
}

void Tetris::Tetris_Iceri()
{
	/*
	Paneli Qurasdirir
	*/

	for (int i = 0; i <= 20; i++)
	{
		for (int j = 0; j <= 11; j++)
		{
			if ((j == 0) || (j == 11) || (i == 20))
			{
				tetris[i][j] = A[i][j] = 9;
			}
			else
			{
				tetris[i][j] = A[i][j] = 0;
			}
		}
	}

	Get_Ranom_Figur();

	gorunus();

}

bool Tetris::Get_Ranom_Figur()
{

	int blokType;
	x = 4;
	y = 0;
	srand(time(NULL));
	blokType = 0 + rand() % 6;;
	if (randm == true) {
		for (int i = 0; i < 4; i++)
		{
			for (int j = 0; j < 4; j++)
			{
				blok[i][j] = 0;
				blok[i][j] = tetris_random[blokType][i][j];
			}
		}
	}
	if (randm == false) {
		for (int i = 0; i < 4; i++)
		{
			for (int j = 0; j < 4; j++)
			{

				blok[i][j] = sonraki[i][j];
			}
		}
	}
	this->randm = false;
	for (int i = 0; i < 4; i++)
	{
		for (int j = 0; j < 4; j++)
		{
			sonraki[i][j] = 0;
			sonraki[i][j] = tetris_random[blokType][i][j];
		}
	}
	for (int i = 0; i < 4; i++)
	{
		for (int j = 0; j < 4; j++)
		{
			tetris[i][j + 4] = A[i][j + 4] + blok[i][j];

			if (tetris[i][j + 4] > 1)
			{
				gameover = true;
				return true;
			}
		}
	}

	return false;
}

void Tetris::Sag_Sol_(int x2, int y2)
{

	// blok qaldir
	for (int i = 0; i < 4; i++)
	{
		for (int j = 0; j < 4; j++)
		{
			tetris[y + i][x + j] -= blok[i][j];
		}
	}

	x = x2;
	y = y2;


	for (int i = 0; i < 4; i++)
	{
		for (int j = 0; j < 4; j++)
		{
			tetris[y + i][x + j] += blok[i][j];
		}
	}

	gorunus();

}

void Tetris::Tetris1()
{
	for (int i = 0; i < 21; i++)
	{
		for (int j = 0; j < 12; j++)
		{
			A[i][j] = tetris[i][j];
		}
	}

}

bool Tetris::Tetris2(int x2, int y2)
{
	for (int i = 0; i < 4; i++)
	{
		for (int j = 0; j < 4; j++)
		{
			if (blok[i][j] && A[y2 + i][x2 + j] != 0)
			{
				return true;
			}
		}
	}
	return false;
}

void Tetris::tetrsi_istifadeci()
{
	char key;

	key = _getch();

	switch (key)
	{
	case 'd':
	case _RIGHT:
		if (!Tetris2(x + 1, y))
		{
			Sag_Sol_(x + 1, y);
		}
		break;
	case 'a':
	case _LEFT:

		if (!Tetris2(x - 1, y))
		{
			Sag_Sol_(x - 1, y);
		}
		break;
	case 's':
	case _DOWN:
		if (!Tetris2(x, y + 1))
		{
			Sag_Sol_(x, y + 1);
		}
		break;
	case ' ':
	case 'w':
	case _UP:
		Tetris_rota();
	}
}

bool Tetris::Tetris_rota()
{
	int tmp[4][4];

	for (int i = 0; i < 4; i++)
	{ //muveqqeti yadda saxla
		for (int j = 0; j < 4; j++)
		{
			tmp[i][j] = blok[i][j];
		}
	}

	for (int i = 0; i < 4; i++)
	{ //Rotate
		for (int j = 0; j < 4; j++)
		{
			blok[i][j] = tmp[3 - j][i];
		}
	}

	if (Tetris2(x, y))
	{ //en axira dushur dayanir
		for (int i = 0; i < 4; i++)
		{
			for (int j = 0; j < 4; j++)
			{
				blok[i][j] = tmp[i][j];
			}
		}
		return true;
	}

	for (int i = 0; i < 4; i++)
	{
		for (int j = 0; j < 4; j++)
		{
			tetris[y + i][x + j] -= tmp[i][j];
			tetris[y + i][x + j] += blok[i][j];
		}
	}

	gorunus();

	return false;
}

void Tetris::Tetris_1()
{
	if (!Tetris2(x, y + 1))
	{
		Sag_Sol_(x, y + 1);
	}
	else
	{

		SearchLines();
		Tetris1();
		Get_Ranom_Figur();
		gorunus();



	}
}
void Tetris::Clear_line(int uIndex)
{

	int g = 0;
	for (int i = uIndex; i > 0; i--) {
		for (int j = 0; j < 12; j++)
		{

			tetris[i][j] = tetris[i - 1][j];



		}
	}




}

void Tetris::SearchLines()
{
	int uNumBlocks = 0;

	for (int i = 0; i < 23; ++i)
		for (int j = 1; j < 14; ++j)
			if (tetris[i][j] == 0)
			{
				uNumBlocks = 0;

				break;
			}
			else
			{

				uNumBlocks++;
				if (uNumBlocks >= 12)
				{
					Clear_line(i);

					++uLines;
					--i;
					uNumBlocks = 0;

				}
			}

	leavel();
}

void Tetris::leavel()
{

	for (int k = 1; k < 5; k++)
		if (uLines == k)
		{

			score += k * 400;

		}




	if (score >= 3000 && score <= 4000)
	{
		leavel1 = 1;
	}
	if (score >= 5000 && score <= 6000)
	{
		leavel1 = 2;
	}
	if (score >= 7000 && score <= 9000)
	{
		leavel1 = 3;
	}
	if (score >= 10000 && score <= 11000)
	{
		leavel1 = 4;
	}
	if (score >= 15000 && score <= 16000)
	{
		leavel1 = 5;
	}

	if (leavel1 == 1)
	{
		GAMESPEED = 15000;

	}
	if (leavel1 == 2)
	{
		GAMESPEED = 10000;

	}
	if (leavel1 == 3)
	{
		GAMESPEED = 6000;

	}
	if (leavel1 == 4)
	{
		GAMESPEED = 3000;

	}
	if (leavel1 == 5)
	{
		GAMESPEED = 1500;

	}




	//line sifirla
	uLines = 0;

}
