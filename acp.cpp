#include "Header.h"

Admin::Admin()
{
}
Admin::~Admin()
{
}
bool Admin::Login()
{
	std::string a;
	std::string b;
	cout << "Enter Admin Login" << endl;
	getline(cin, a);
	cout << "Enter Admin Pass" << endl;
	getline(cin, b);

	if (admin_login == a)
		if (admin_pass == b)
		{
			{
				return true;

			}
		}
	return false;


}
void Admin::change()
{
	cin.ignore();
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
void Admin::new_user()
{
	std::string a;
	std::string b;
	std::string c;

	cout << "Enter User Name - Surname" << endl;
	getline(cin, a);
	cout << "Enter HomeNomber" << endl;
	getline(cin, b);
	cout << "Enter Duzeler" << endl;
	getline(cin, c);
	a += " ";
	a += b;
	a += " ";
	a += c;
	a += " ";
	this->User[j++] = a;


}
void  Admin::user_print()
{
	for (size_t i = 0; i < j; i++)
	{
		cout << User[i] << endl;

	}
}
void Admin::fileopen()
{

	char name;
	int i = 0;

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

	int a;
	cout << str << endl;

	cin >> a;
	if (a == 1)
	{
		this->Exam_Yes += 1;
	}
	else if (a == 2)
	{
		this->Exam_No += 1;
	}
	else if (a == 3)
	{
		this->Exam_No += 1;
	}
	else if (a == 4)
	{
		this->Exam_No += 1;
	}


	str = "";

}
void Admin::GMOVER(std::string text)
{
	for (int i = 0; text[i] != 0; i++)
	{
		Sleep(3);
		std::cout << text[i];
	}
}
void Admin::Exam_Final()
{





}
void Admin::Admin_Panel()
{
	int w;
	int i = 0;
	cout << "Creat New User[1]" << endl;
	cout << "Imtahan Neticeleri[2]" << endl;
	cout << "User Silme[3]" << endl;
	cout << "Redakte Etme[4]" << endl;
	cout << "Yeni Sual Elave Etme[5]" << endl;
	cin >> w;
	if (w == 1)
	{
		std::string a;
		std::string b;
		std::string c;
		cin.ignore();
		cout << "Enter User Name - Surname" << endl;
		getline(cin, a);
		cout << "Enter HomeNomber" << endl;
		getline(cin, b);
		cout << "Enter Duzeler" << endl;
		getline(cin, c);
		a += " ";
		a += b;
		a += " ";
		a += c;
		a += " ";
		User[j++] = a;
			
	}
	if (w == 2)
	{
		cout << "[ User List ]" << endl;
		while (i < j) {
			cout<< "("<<i<<")" << User[i] << endl;
			i++;
		}
	}
	if (w == 3)
	{
		cin >> i;
		cout << User[i] << "User Imtahan Neticesi" << endl;


	}






}


void Admin::timer()
{
	


}
