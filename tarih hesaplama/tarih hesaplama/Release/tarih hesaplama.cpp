#include <iostream>

using namespace std;

int date_y;//bugunun yil degeri
int date_m;//bugunun ay degeri
int date_d;//bugunun gun degeri


void logStart(int valueEnt);
void fonc1();
void fonc2();
void fonc3();
void fonc4();
void fonc5();
void fonc6();
void calculateDays(int year1, int year2, int month1, int month2, int day1, int day2);
void findLessDate(int year1, int month1, int day1, int variableDays);
void findUpDate(int year1, int month1, int day1, int variableDays);

//girilen tariin artik yil olup olmadigini kontrol eder
bool leapYear(int insertYear)
{
	if (insertYear % 4 == 0)
	{
		if (insertYear % 400 == 0) { return true; }
		if (insertYear % 100 == 0) { return false; }
		else { return true; }
	}
	else
	{
		return false;
	}
}

//girilen tarikhteki ayin kac gunden olustugunu verir
int daysOfMonth(int year,int month) {
	switch (month)
	{
	case 1: case 3: case 5: case 7: case 8: case 10: case 12:
		return  31;
		break;
	case 4: case 6: case 9: case 11:
		return  30;
		break;
	case 2:
		if (leapYear(year)==true) {
			return  29;
		}
		else { return  28; }
		break;
	}
}

//Girilen tarihin dogru olup olmdaigini kontrol edecek fonksiyon
bool dateCont(int year,int month,int day)
{
	if(month<=12&&month>0)
	{
		if (day <= daysOfMonth(year, month)&&day>0)
		{
			return true;
		}
		else { 
		cout << "Gecersiz tarih girdiniz. Tekrar giriniz." << endl;
		return false;
		}
	}
	else { 
	cout << "Gecersiz tarih girdiniz. Tekrar giriniz." << endl;
	return false;
	}
}

//Bugunun tarihi girildikten sonra ekrana cikacak olan komutlar.
void comments()
{
	int valueEnt;
	cout << "programin hangi fonksiyonunu kullanmak istiyorsunuz? Tuslayiniz." << endl << endl;
	cout << "num 1 =>  Iki tarih arasindaki gun farkinin bulunmasi " << endl;
	cout << "num 1 =>  Gecmisteki bir tarihten bugune kadar gecen gun sayisi " << endl;
	cout << "num 1 =>  Girdiginiz bir yil icerisindeki iki tarih arasindaki gun farki " << endl;
	cout << "num 1 =>  Girdiginiz bir tarihten girdiginiz belli gun sonraki tarih " << endl;
	cout << "num 1 =>  Bugunden verilen gun sayisi kadar onceki tarihin bulunmasi " << endl;
	cout << "num 1 =>  Bugunden verilen gun sayisi kadar sonraki tarihin bulunmasi " << endl;
	cout << "num 1 =>  Cikis " << endl;
	cin >> valueEnt;
	logStart(valueEnt);
}

//programin ilk basindaki bugunun tarihini verme komutlari
void todayDate()
{
	cout << "Lutfen bugunun tarihini giriniz" << endl << "Yil = ";
	cin >> date_y;
	cout << "Ay = ";
	cin >> date_m;
	cout << "Gun =";
	cin >> date_d;
	cout << "TARIH === " << date_y << "/" << date_m << "/" << date_d <<"===================================================" <<endl<<endl;
	if (dateCont(date_y, date_m, date_d) == false) 
	{
		todayDate(); 
	}
}

//menude girilen degere gore calistirilacak fonksiyona yonlendirme
void logStart(int valueEnt)
{
	if (valueEnt == 1)
	{
		fonc1();
		comments();
	}
	if(valueEnt==2)
	{
		fonc2();	
		comments();
	}
	if(valueEnt==3)
	{
		fonc3();
		comments();
	}
	if(valueEnt==4)
	{
		fonc4();
		comments();
	}
	if (valueEnt == 5) 
	{
		fonc5();
		comments();
	}
	if(valueEnt==6)
	{
		fonc6();
		comments();
	}
	if(valueEnt==7)
	{
		return;
	}
}

//bir yilin artik yil olup olmamasina gore 365 ya da 366 gun olmasini kontrol eder
int daysOfYear(int year)
{
	if (leapYear(year) == true) { return 366; }
	else { return 365; }
}

//klavyeden girile iki tarih arasindaki gun farkinin bulunmasini saglayan fonksiyon
void fonc1()
{
	int year1, year2, month1, month2, day1, day2;
	cout << "Aralarindaki gun farkinin bulunmasini istediginiz 2 tarih giriniz." << endl << "1. Yil" << endl;
	cin >> year1;
	cout << "1. Ay" << endl;
	cin >> month1;
	cout << "1. Gun" << endl;
	cin >> day1;
	if (dateCont(year1, month1, day1) == false) { fonc1(); }
	cout << "2. Yil" << endl;
	cin >> year2;
	cout << "2. Ay" << endl;
	cin >> month2;
	cout << "2. Gun" << endl;
	cin >> day2;
	if (dateCont(year2, month2, day2) == false) { fonc1(); }
	cout << "girmis olgugunuz 1. tarih " << day1 << "/" << month1 << "/" << year1 << endl << "girmis oldugunuz 2. tarih " << day2 << "/" << month2 << "/" << year2 << endl;
	calculateDays(year1, year2, month1, month2, day1, day2);
}

//program baslatildiginda girilen tarih ile istedginiz bir tarih arasindaki farki bulmaya yarayan fonksiyon
void fonc2()
{
	int year1, month1, day1;
	cout << "Bugun ile arasndaki gun farkini bulmak istediginiz tarihi giriniz. " << endl << "Yil " << endl;
	cin >> year1;
	cout << "Ay" << endl;
	cin >> month1;
	cout << "Gun" << endl;
	cin >> day1;
	cout << "girmis oldugunuz tarih " << day1 << "/" << month1 << "/" << year1<<endl;
	if (dateCont(year1, month1, day1) == false) { fonc2(); }
	calculateDays(year1, date_y, month1, date_m, day1, date_d);
}

//girilen bir yil icerisindeki iki tarih arasi gun farkini hesaplayan fonksiyon
void fonc3()
{
	int year1, year2, month1, month2, day1, day2;
	cout << "Aralarindaki gun farkinin bulunmasini istediginiz yili giriniz" << endl << "Yil" << endl;
	cin >> year1;
	cout << "Simdi iki arasindaki gun farkinin hesaplanmasini istediginiz tarihleri giriniz" <<endl<<"1. Ay"<< endl;
	cin >> month1;
	cout << "1. Gun" << endl;
	cin >> day1;
	if (dateCont(year1, month1, day1) == false) { fonc3(); }
	cout << "2. Ay" << endl;
	cin >> month2;
	cout << "2. Gun" << endl;
	cin >> day2;
	if (dateCont(year1, month2, day2) == false) { fonc3(); }
	cout << "girmis oldugunuz 1. tarih " << day1 << "/" << month1 << "/" << year1 <<endl<< "girmis oldugunuz 2. tarih " << day2 << "/" << month2 << "/" << year1 << endl ;

	calculateDays(year1, year1, month1, month2, day1, day2);
}

//klavyeden girdiginiz bir tarihten itibaren yine klavyeden girdiginiz gun sayisi kadar sonra gelen tarihin bulunmasi
void fonc4()
{
	int year1, month1, day1, variableDays;
	cout << "Baslangic yili degeri giriniz." << endl << "Yil " << endl;
	cin >> year1;
	cout << "Ay" << endl;
	cin >> month1;
	cout << "Gun" << endl;
	cin >> day1;
	if (dateCont(year1, month1, day1) == false) { fonc4(); }
	cout << "girmis oldugunuz tarih " << day1 << "/" << month1 << "/" << year1 << endl;
	cout << "Ileriye gidilmesii istediginiz gun sayisini giriniz." << endl;
	cin >> variableDays;
	findUpDate(year1,month1,day1,variableDays);
}

//program baslatildiginda girilen tarihden baslayarak klavyeden girdiginiz gun sayisi kadar once gelen tarihin bulunmasi
void fonc5()
{
	int variableDays;
	cout << "Geriye gidilmesii istediginiz gun sayisini giriniz." << endl;
	cin >> variableDays;
	findLessDate(date_y, date_m, date_d, variableDays);
}

//program baslatildiginda girilen tarihden baslayarak klavyeden girdiginiz gun sayisi kadar sonra gelen tarihin bulunmasi
void fonc6()
{
	int variableDays;
	cout << "Ileriye gidilmesii istediginiz gun sayisini giriniz." << endl;
	cin >> variableDays;
	findUpDate(date_y, date_m, date_d, variableDays);
}

//girilen iki tarih arasindaki gun farkini bulan fonksiyon
void calculateDays(int year1, int year2, int month1, int month2, int day1, int day2)
{
	int toplamGun = 0;
	if(year1!=year2)
	{
		if (year1 < year2) {
			for (int i = year1+1;i<year2;i++)
			{
				toplamGun += daysOfYear(i);
			}
			for(int i=month1+1;i<=12;i++)
			{
				toplamGun += daysOfMonth(year1,i);
			}
			for(int i=1;i<month2;i++)
			{
				toplamGun += daysOfMonth(year2,i);
			}
			toplamGun = toplamGun+(daysOfMonth(year1,month1) - day1);
			toplamGun += day2;
		}
		else
		{
			for (int i = year2 + 1; i < year1; i++)
			{
				toplamGun += daysOfYear(i);
			}
			for (int i = month2+1; i <= 12; i++)
			{
				toplamGun += daysOfMonth(month2,i);
			}
			for (int i = 1; i < month1; i++)
			{
				toplamGun += daysOfMonth(year1,i);
			}
			toplamGun =toplamGun+( daysOfMonth(month2,month2) - day2);
			toplamGun += day1;
		}

	}else if(month1!=month2)
	{
		if (month1 < month2)
		{
			for (int i = month1+1; i < month2; i++)
			{
				toplamGun += daysOfMonth(year1,i);
			}
			toplamGun = toplamGun+(daysOfMonth(year1,month1) - day1);
			toplamGun += day2;
		}else
		{
			for (int i = month2+1; i < month1; i++)
			{
				toplamGun += daysOfMonth(year2,i);
			}
			toplamGun = toplamGun+(daysOfMonth(year2,month2) - day2);
			toplamGun += day1;
		}
	}else if(day1!=day2)
	{
		toplamGun = day1 - day2;
		if (toplamGun < 0) { toplamGun = toplamGun* -1; }
	}
	else
	{
		cout << "girilen degerler zaten ayni gune ait" << endl;
	}
	cout << "Girdiginiz " << day1 << "/" << month1 << "/" << year1 << " ve " <<day2 << "/" 
		 << month2 << "/" << year2 << " tarihleri arasindaki gun farki =>   " << toplamGun << endl << endl;
}

//girilen tarihten girilen gun sayisi kadar onceki tarihi bulan fonksiyon
void findLessDate(int year1, int month1, int day1,int variableDays)
{
	int out_y;
	int out_m;
	int out_d;
	int vDays;

	out_y = year1;
	out_m = month1;
	out_d = day1;
	vDays = variableDays;

	vDays = vDays - day1;
	out_m -= 1;
	for(int i = vDays;vDays> daysOfMonth(out_y,out_m);i++)
	{
		vDays -= daysOfMonth(out_y,out_m);
		out_m -= 1;
		if (out_m == 0) 
		{
			out_m = 12;
			out_y -= 1; 
		}
	}
	out_d = daysOfMonth(out_y,out_m-1)- vDays;
	cout << day1 << "/" << month1 << "/" << year1 <<" tarihinden "<<variableDays << " gun onceki tarih =>  " <<out_d << "/"<<out_m <<"/"<< out_y<<endl<<endl;
}

//girilen tarihten girilen gun sayisi kadar sonraki tarihi bulan fonksiyon
void findUpDate(int year1, int month1, int day1, int variableDays)
{
	int out_y;
	int out_m;
	int out_d;
	int vDays;

	out_y = year1;
	out_m = month1;
	out_d = day1;
	vDays = variableDays;

	vDays = vDays - (daysOfMonth(out_y,out_m)- day1);
	out_m += 1;
	if (out_m == 13)
	{
		out_m = 1;
		out_y += 1;
	}
	for (out_m; vDays > daysOfMonth(out_y,out_m); out_m)
	{
		
		vDays -= daysOfMonth(out_y,out_m);
		out_m++;
		if (out_m == 13)
		{
			out_m = 1;
			out_y += 1;
		}
	}
	out_d =  vDays;
	cout << day1 << "/" << month1 << "/" << year1 << " tarihinden " << variableDays << " gun sonraki tarih =>  " << out_d << "/" << out_m << "/" << out_y << endl << endl;
}

int main()
{
	int valueEnt = 0;
	todayDate();
	comments();
	logStart(valueEnt);
}