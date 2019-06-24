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
Admin::Admin()
{

}
Admin::~Admin()
{
	delete[] User_login;

}

//=======================
void Admin::GMOVER(std::string text)
{
	for (int i = 0; text[i] != 0; i++)
	{
		Sleep(3);
		std::cout << text[i];
	}
}
void Admin::GotoXY(int column, int line)
{
	COORD coord;
	coord.X = column;
	coord.Y = line;
	SetConsoleCursorPosition(
		GetStdHandle(STD_OUTPUT_HANDLE),
		coord
	);
}
void Admin::CHARRR()
{

	HANDLE out = GetStdHandle(STD_OUTPUT_HANDLE);
	CONSOLE_CURSOR_INFO  coursorInfo;
	GetConsoleCursorInfo(out, &coursorInfo);
	coursorInfo.bVisible = false;
	SetConsoleCursorInfo(out, &coursorInfo);
}
//========================

bool Admin::Login()
{
	HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	const int saved_colors = GetConsoleTextAttribute(hConsole);

	system("cls");

	std::string a;
	std::string b;
	GotoXY(40, 0);
	cout << "Enter Admin Login" << endl;
	GotoXY(40, 1);
	SetConsoleTextAttribute(hConsole, 241);
	cout << "                     ";
	GotoXY(40, 1);
	getline(cin, a);
	SetConsoleTextAttribute(hConsole, saved_colors);
	GotoXY(40, 2);
	cout << "Enter Admin Pass" << endl;
	GotoXY(40, 3);
	SetConsoleTextAttribute(hConsole, 241);
	cout << "                     ";
	GotoXY(40, 3);
	getline(cin, b);
	SetConsoleTextAttribute(hConsole, saved_colors);
	if (admin_login == a)
	{
		if (admin_pass == b)
			{
				system("cls");
				return true;

			}
		}
	else {
		system("cls");
		GotoXY(40, 10);
		cout << "Login Veya Sifre Sefdi";

		GotoXY(0, 0);
		return false;
	}

} 
void Admin::change()
{

	std::string a;
	std::string b;

	cout << "Enter Admin Login : " << endl;
	getline(cin, a);
	cout << "Enter Admin Pass : " << endl;
	getline(cin, b);
	if (admin_login == a)
	{
		if (admin_pass == b)
		{
			cout << "Enter New Login : " << endl;
			getline(cin, admin_login);
			cout << "Enter New Pass : " << endl;
			getline(cin, admin_pass);

		}
	}

	cout << "Change Admin Login , Pass " << endl;



}
void Admin::Admin_Panel()
{
	HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	const int saved_colors = GetConsoleTextAttribute(hConsole);
	int a = 0;
	while (1)
	{
		SetConsoleTextAttribute(hConsole, 241);
		cout << "ADMIN PANEL\n";
		cout << "Creat New User[1]" << endl;
		cout << "";
		SetConsoleTextAttribute(hConsole, saved_colors);





	}
}
void Admin::ADMIN_PANEL_ENTER()
{
	int a;
	if (Login()) {
		Admin_Panel();
		}

	
}

/*User Control */
bool Admin::User_login_Panel()
{
	system("cls");
	HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	const int saved_colors = GetConsoleTextAttribute(hConsole);
	int i = 0;
	std::string a;
	std::string b;
	GotoXY(40, 0);
	cout << "Enter User Login" << endl;
	SetConsoleTextAttribute(hConsole, 241);
	GotoXY(40, 1);
	cout << "                     ";
	GotoXY(40, 1);
	getline(cin, a);
	SetConsoleTextAttribute(hConsole, saved_colors);
	GotoXY(40, 2);
	cout << "Enter User Passworld" << endl;
	GotoXY(40, 3);
	SetConsoleTextAttribute(hConsole, 241);
	cout << "                     ";
	GotoXY(40, 3);
	getline(cin, b);
	SetConsoleTextAttribute(hConsole, saved_colors);
	while (i < user_count)
	{

		if (User_login[i] == a)
		{
			if (User_pass[i] == b)
			{
				this->user_id_print = i;
				return true;
			}
		}
		i++;
	}
	return false;


}
void Admin::new_user()
{
	HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	const int saved_colors = GetConsoleTextAttribute(hConsole);

	
	SetConsoleTitle("Imtahan Systemi");
	system("cls");
	std::string a;
	std::string b;
	std::string c;
	GotoXY(40, 0);
	cout << "Enter Login : ";
	SetConsoleTextAttribute(hConsole, 241);
	GotoXY(40, 1);
	cout << "                     ";
	
	GotoXY(40, 1);
	getline(cin, User_login[this->user_count]);
	SetConsoleTextAttribute(hConsole, saved_colors);
	GotoXY(40, 2);
	cout << "Enter Passworld: ";
	SetConsoleTextAttribute(hConsole, 241);
	GotoXY(40, 3);
	cout << "                     ";

	GotoXY(40, 3);
	getline(cin, User_pass[this->user_count]);
	SetConsoleTextAttribute(hConsole, saved_colors);
	
	GotoXY(40, 4);
	cout << "Enter User Name - Surname" << endl;
	SetConsoleTextAttribute(hConsole, 241);
	GotoXY(40, 5);
	cout << "                     ";

	GotoXY(40, 5);
	getline(cin, a);
	SetConsoleTextAttribute(hConsole, saved_colors);
	GotoXY(40, 6);
	cout << "Enter HomeNomber" << endl;
	GotoXY(40,7);
	SetConsoleTextAttribute(hConsole, 241);
	cout << "                     ";

	GotoXY(40, 7);
	getline(cin, b);
	SetConsoleTextAttribute(hConsole, saved_colors);
	GotoXY(40, 8);
	cout << "Enter Duzeler" << endl;
	GotoXY(40, 9);
	SetConsoleTextAttribute(hConsole, 241);
	cout << "                     ";

	GotoXY(40, 9);
	getline(cin, c);
	SetConsoleTextAttribute(hConsole, saved_colors);
	a += " ";
	a += b;
	a += " ";
	a += c;
	a += " ";

	this->user_count++;
	this->ID[this->User_id_count] = this->user_count;
	this->User[j++] = a;
	this->User_id_count++;

}
void  Admin::user_print()
{
	HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	const int saved_colors = GetConsoleTextAttribute(hConsole);
	system("cls");
	for (size_t i = 0,k=1; i < j; i++)
	{
		
			SetConsoleTextAttribute(hConsole, 241);
			GotoXY(40, i+2);
			cout << "                              ";
			GotoXY(40, i+2);
			cout << User[i] << ' ';
			SetConsoleTextAttribute(hConsole, saved_colors);

	}
	Sleep(900);
	system("pause");
}
void Admin::fileopen()
{

	char name;



	if (this->file == 1) {
		ifstream file1("file1.txt");
		if (file1.is_open())
		{
			while (file1.get(name))
			{
				str += name;
			}
			file1.close();

		}
		this->file++;
		return;

	}
	if (this->file == 2) {
		ifstream file1("file2.txt");
		if (file1.is_open())
		{
			while (file1.get(name))
			{
				str += name;
			}
			file1.close();

		}
		this->file++;
		return;
	}
	if (this->file == 3) {
		ifstream file1("file3.txt");
		if (file1.is_open())
		{
			while (file1.get(name))
			{
				str += name;
			}
			file1.close();

		}
		this->file++;
		return;
	}



}
void Admin::Exam()
{
	system("cls");
	HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	const int saved_colors = GetConsoleTextAttribute(hConsole);
	int count = 0;
	int a;
	int i = 0;
	while (1) {
		system("cls");
		GotoXY(40, 0);
		SetConsoleTextAttribute(hConsole, 12);
		cout << "IMTAHAN BASLADI";
		SetConsoleTextAttribute(hConsole, saved_colors);
		cout << endl;
		SetConsoleTextAttribute(hConsole, 10);
		const char* str1 = "Y";
		const char* str2 = "N";
		cout << str << endl;
		cin >> a;
		cin.ignore();
		if (a == 1)
		{
			for (int i = 0; str[i] != 0; i++)
			{
				if (str[i] == '(')
				{
					i++;
					if (str[i] == '1') {

						for (int j = 0; str1[j] != 0; j++)
						{

							str[i] = str1[j];
						}
					}

				}
			}
			this->Exam_Yes += 12;

			this->exam = true;
		}
		else if (a == 2)
		{
			for (int i = 0; str[i] != 0; i++)
			{
				if (str[i] == '(')
				{
					i++;
					if (str[i] == '2') {

						for (int j = 0; str1[j] != 0; j++)
						{

							str[i] = str2[j];
						}
					}

				}
			}

			this->Exam_No += 0;
			this->exam = true;
		}
		else if (a == 3)
		{
			for (int i = 0; str[i] != 0; i++)
			{
				if (str[i] == '(')
				{
					i++;
					if (str[i] == '3') {

						for (int j = 0; str1[j] != 0; j++)
						{

							str[i] = str1[j];
						}
					}

				}
			}

			this->Exam_Yes += 1;
			this->exam = true;
		}
		else if (a == 4)
		{
			for (int i = 0; str[i] != 0; i++)
			{
				if (str[i] == '(')
				{
					i++;
					if (str[i] == '2') {

						for (int j = 0; str1[j] != 0; j++)
						{

							str[i] = str1[j];
						}
					}

				}
			}

			this->Exam_Yes += 1;
			this->exam = true;
		}
		else
		{
			cout << "Bele Bir Secim Yoxdu\n";
			this->exam = false;
		}
		Exam_1[count++] = str;
		str = "";
		i++;
		if (this->exam) {
			fileopen();
			if (i > 2) {
				break;

			}
		}
		SetConsoleTextAttribute(hConsole, saved_colors);

	}
	SetConsoleTextAttribute(hConsole, saved_colors);


}
void Admin::Exam_Print_Final()
{

	HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	const int saved_colors = GetConsoleTextAttribute(hConsole);
	int i = 0;
	while (i < 3)
	{
		SetConsoleTextAttribute(hConsole, 10);
		cout << Exam_1[i] << endl;
		SetConsoleTextAttribute(hConsole, saved_colors);
		i++;
	}
}
void Admin::User_Panel()
{
	HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	const int saved_colors = GetConsoleTextAttribute(hConsole);

	std::string namefile;
	std::string a;
	while (true)
	{
		system("cls");
		GotoXY(40, 0);
		SetConsoleTextAttribute(hConsole, 3);
		cout << "User :" << User_login[user_id_print] << " ID :" << ID[user_id_print];
		SetConsoleTextAttribute(hConsole, saved_colors);
		GotoXY(40, 1);
		SetConsoleTextAttribute(hConsole, 11);
		cout << "Enter Exam[1]" << endl;
		GotoXY(40, 2);
		cout << "Imtahan Neticelerine bax[2]" << endl;
		GotoXY(40, 3);
		cout << "Imtahan Neticelerini File Yaz[3]" << endl;
		SetConsoleTextAttribute(hConsole, saved_colors);
		SetConsoleTextAttribute(hConsole, 241);
		GotoXY(40, 4);
		cout << " ";

		GotoXY(40, 4);
		getline(cin, a);
		SetConsoleTextAttribute(hConsole, saved_colors);
		if (a == "1")
		{
			/*imtahana girish*/
			fileopen();
			Exam();

		}

		if (a == "2")
		{

			Exam_Print_Final();
			system("pause");
			/*neticeleri yazmaq*/
		}
		if (a == "3")
		{

			int i = 0;
			ofstream outfile;
			cout << "Fayilin Adini Yazin" << endl;
			getline(cin, namefile);
			cout << "\a" << "\a" << "\a";
			int msgboxID = MessageBox(
				NULL,
				"Imtahan Neticleri Fayla Yazilsinmi?", "Fayli Yaradilsinmi?",
				MB_OKCANCEL
			);
			if (msgboxID == IDOK) {
				outfile.open(namefile);
				while (i < 3)
				{
					outfile << Exam_1[i];
					i++;
				}
			}
			else {


				cout << "Qovluq Yaradilmadi" << endl;
				Sleep(500);
			}

		}
		if (a == "4")
		{
			if (User_login_Panel())
			{
				User_Panel();
			}
		}
		if (a == "0")
		{
			user_print();
		}
	}

}
/*User Control */
