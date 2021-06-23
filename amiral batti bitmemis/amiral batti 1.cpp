#include <iostream>
#include <cstdlib>
#include <ctime>
#include <random>

using namespace std;

// HARITA HAKKINDA  
// bunun gerceklesmesi gemi uzunlugu 0 olmama sarti aranir.
// 12*12 lik bir savas alani olacagi icin toplamda 144 birimkarelik bir alan gerekli bu alanlarda geminin olup olmadigini ogrenmek icin de 144 elemanli bir dizi tutariz.
// her bir karenin aritmetik sayilar olarak artan numaralari olacak bu dizideki tum elemanlara baslangicta 0 atanacak. ardindan eger dizideki ilgili kareye bir deger 
// atanmak istenirse kontrol edilecek degerler (x1/x2 => yataydaki 1. ve 2. konumlar)(y1/y2 => dikeydeki 1. ve 2. konumlar)  olacak sekilde (x1-1) ile (x2+1) arasindaki
// dizi degerleri 0 mi yoksa 1 mi diye kontrol edilecek aralarinda 1 yoksa ardindan (x1-1) ile (x2+1) arasindaki (y-1) dizi degerleri kontrol edilecek bunda da 1 yoksa 
// (x1-1) ile (x2+1) arasindaki (y+1) dizi degerleri kontrol edilir bundarda da 1 cikmazsa o zaman bu gemilerin yerlesmesinde sorun yotur demektir.
// HARITA ANLAMLAR
// 0 => bos(gemi yok)
// 1 => saglam gemi var
// 2 => geminin o kismi hasar almis yani isabetli atis
// 3 => geminin tum kareleri vurulmus yani gemi batti
// her isabetli atistan sonra geminin diger kisimlari kontrol edilcek eger geminin diger kisimlarinda 1 yok ve diger kisimlar da 2 den olusuyorsa o geminin 2 olan karelerinin 
// hepsini 2 ye donustur.


// GEMILER HAKKINDA    
// gemiler max 10 tane olabilir bundan dolayi 10 elemanli gemiler dizisi olusturarak degerler 0 atanir. bu dizi gemi uzunluklarini tutar. gemilerin sayisi ve uzunluk degerleri 
// kullanici tarafindan girileceginden kac gemi varsa o gemi uzunluk degerlerini kullanicidan isteyip gerekmedigi surece gemi uzunluk degeleri sifir olacak boylece de ext hata 
// vermez 

int findLocation(int axisX, int axisY)
{
	return axisY * 12 + axisX;
}

void shipControl(int axisX, int axisY,int *warArea,int* sinkedShip)
{
	bool isSink = true;
	int loopVariable = axisX;
	int maxShipAmount[10] = {-1};
	int shipNumber = 1;
	maxShipAmount[0] = findLocation(axisX, axisY);
	if (warArea[findLocation(axisX, axisY)] == 1|| warArea[findLocation(axisX, axisY)] == 2)
	{
		while (loopVariable + 1 < 12 && warArea[findLocation(loopVariable + 1, axisY)] !=0)
		{
			if (warArea[findLocation(loopVariable + 1, axisY)] == 1)
			{
				isSink = false;
			}
			if (warArea[findLocation(loopVariable + 1, axisY)] == 2)
			{
				maxShipAmount[shipNumber] = findLocation(loopVariable + 1, axisY);
				shipNumber++;
			}
			loopVariable++;
		}
		if (isSink == true) {
			int loopVariable = axisX;
			while (loopVariable - 1 < 12 && warArea[findLocation(loopVariable - 1, axisY)] != 0)

			{
				if (warArea[findLocation(loopVariable - 1, axisY)] == 1)
				{
					isSink = false;
				}
				if (warArea[findLocation(loopVariable - 1, axisY)] == 2)
				{
					maxShipAmount[shipNumber] = findLocation(loopVariable - 1, axisY);
					shipNumber++;
				}
				loopVariable--;
			}
		}
		if (isSink == true) {
			int loopVariable = axisY;
			while (loopVariable + 1 < 12 && warArea[findLocation(axisX, loopVariable + 1)] != 0)
			{
				if (warArea[findLocation(axisX, loopVariable + 1)] == 1)
				{
					isSink = false;
				}
				if (warArea[findLocation(axisX, loopVariable + 1)] == 2)
				{
					maxShipAmount[shipNumber] = findLocation(axisX, loopVariable + 1);
					shipNumber++;
				}
				loopVariable++;
			}
		}
		if (isSink == true) {
			int loopVariable = axisY;
			while (loopVariable - 1 < 12 && warArea[findLocation(axisX, loopVariable - 1)] != 0)

			{
				if (warArea[findLocation(axisX, loopVariable - 1)] == 1)
				{
					isSink = false;
				}
				if (warArea[findLocation(axisX, loopVariable - 1)] == 2)
				{
					maxShipAmount[shipNumber] = findLocation(axisX, loopVariable - 1);
					shipNumber++;
				}
				loopVariable--;
			}
		}

		if (isSink == true)
		{
			for (int i = 0; maxShipAmount[i] > 0; i++)
			{
				warArea[maxShipAmount[i]] = 4;
			}
			*sinkedShip = *sinkedShip + 1;
		}
	}
}

void placement(int* warArea, int* shipLong, int* shipNumber)
{
	int axisX = 0;
	int axisY = 0;
	axisX = rand() % 12;
	axisY = rand() % 12;
	bool  isVertical = true;//random sayi cift sayi olursa yatay, tek sayi olursa dikey olur.{
	if (rand() % 2 == 0)
	{
		isVertical = false; //yatay
	}
	else
	{
		isVertical = true; //dikey
	}
	if (shipLong[*shipNumber] != 0)
	{

		bool isEmpty = true;
		if (isVertical == false)
		{
			if (axisX + shipLong[*shipNumber] < 12)
			{
				if (axisX - 1 > 0)
				{
					if (axisX + shipLong[*shipNumber] + 1 < 12)
					{
						for (int i = axisX - 1; i < axisX + shipLong[*shipNumber]; i++)
						{
							if (warArea[findLocation(i, axisY)] != 0)
							{
								isEmpty = false;
							}
						}
						for (int i = axisX - 1; i < axisX + shipLong[*shipNumber]; i++)
						{
							if (warArea[findLocation(i, axisY + 1)] != 0)
							{
								isEmpty = false;
							}
						}
						for (int i = axisX - 1; i < axisX + shipLong[*shipNumber]; i++)
						{
							if (warArea[findLocation(i, axisY - 1)] != 0)
							{
								isEmpty = false;
							}
						}

					}
					else
					{
						for (int i = axisX - 1; i < axisX + shipLong[*shipNumber] - 1; i++)
						{
							if (warArea[findLocation(i, axisY)] != 0)
							{
								isEmpty = false;
							}
						}
						if (axisY + 1 < 12)
						{
							for (int i = axisX - 1; i < axisX + shipLong[*shipNumber] - 1; i++)
							{
								if (warArea[findLocation(i, axisY + 1)] != 0)
								{
									isEmpty = false;
								}
							}
						}
						if (axisY > 0)
						{
							for (int i = axisX - 1; i < axisX + shipLong[*shipNumber] - 1; i++)
							{
								if (warArea[findLocation(i, axisY - 1)] != 0)
								{
									isEmpty = false;
								}
							}
						}
					}
				}
				else
				{
					if (axisX + shipLong[*shipNumber] + 1 < 12)
					{

						for (int i = axisX; i < axisX + shipLong[*shipNumber]; i++)
						{
							if (warArea[findLocation(i, axisY)] != 0)
							{
								isEmpty = false;
							}
						}
						for (int i = axisX; i < axisX + shipLong[*shipNumber]; i++)
						{
							if (warArea[findLocation(i, axisY + 1)] != 0)
							{
								isEmpty = false;
							}
						}
						for (int i = axisX; i < axisX + shipLong[*shipNumber]; i++)
						{
							if (warArea[findLocation(i, axisY - 1)] != 0)
							{
								isEmpty = false;
							}
						}
					}
					else
					{
						for (int i = axisX; i < axisX + shipLong[*shipNumber] - 1; i++)
						{
							if (warArea[findLocation(i, axisY)] != 0)
							{
								isEmpty = false;
							}
						}
						for (int i = axisX; i < axisX + shipLong[*shipNumber] - 1; i++)
						{
							if (warArea[findLocation(i, axisY + 1)] != 0)
							{
								isEmpty = false;
							}
						}
						for (int i = axisX; i < axisX + shipLong[*shipNumber] - 1; i++)
						{
							if (warArea[findLocation(i, axisY - 1)] != 0)
							{
								isEmpty = false;
							}
						}
					}
				}
			}
			else
			{
				isEmpty = false;
			}
		}
		else
		{
			if (axisY + shipLong[*shipNumber] < 12)
			{
				if (axisY + shipLong[*shipNumber] < 12)
				{
					if (axisY - 1 > 0)
					{
						if (axisY + shipLong[*shipNumber] + 1 < 12)
						{
							for (int i = axisY - 1; i < axisY + shipLong[*shipNumber]; i++)
							{
								if (warArea[findLocation(axisX, i)] != 0)
								{
									isEmpty = false;
								}
							}
							for (int i = axisY - 1; i < axisY + shipLong[*shipNumber]; i++)
							{
								if (warArea[findLocation(axisX + 1, i)] != 0)
								{
									isEmpty = false;
								}
							}
							for (int i = axisY - 1; i < axisY + shipLong[*shipNumber]; i++)
							{
								if (warArea[findLocation(axisX - 1, i)] != 0)
								{
									isEmpty = false;
								}
							}
						}
						else
						{
							for (int i = axisY - 1; i < axisY + shipLong[*shipNumber] - 1; i++)
							{
								if (warArea[findLocation(axisX, i)] != 0)
								{
									isEmpty = false;
								}
							}
							for (int i = axisY - 1; i < axisY + shipLong[*shipNumber] - 1; i++)
							{
								if (warArea[findLocation(axisX + 1, i)] != 0)
								{
									isEmpty = false;
								}
							}
							for (int i = axisY - 1; i < axisY + shipLong[*shipNumber] - 1; i++)
							{
								if (warArea[findLocation(axisX - 1, i)] != 0)
								{
									isEmpty = false;
								}
							}
						}
					}
					else
					{
						if (axisY + shipLong[*shipNumber] + 1 < 12)
						{

							for (int i = axisY; i < axisY + shipLong[*shipNumber]; i++)
							{
								if (warArea[findLocation(axisX, i)] != 0)
								{
									isEmpty = false;
								}
							}
							for (int i = axisY - 1; i < axisY + shipLong[*shipNumber]; i++)
							{
								if (warArea[findLocation(axisX + 1, i)] != 0)
								{
									isEmpty = false;
								}
							}
							for (int i = axisY - 1; i < axisY + shipLong[*shipNumber]; i++)
							{
								if (warArea[findLocation(axisX - 1, i)] != 0)
								{
									isEmpty = false;
								}
							}
						}
						else
						{
							for (int i = axisY; i < axisY + +shipLong[*shipNumber]; i++)
							{
								if (warArea[findLocation(axisX, i)] != 0)
								{
									isEmpty = false;
								}
							}
							for (int i = axisY - 1; i < axisY + shipLong[*shipNumber]; i++)
							{
								if (warArea[findLocation(axisX + 1, i)] != 0)
								{
									isEmpty = false;
								}
							}
							for (int i = axisY - 1; i < axisY + shipLong[*shipNumber]; i++)
							{
								if (warArea[findLocation(axisX - 1, i)] != 0)
								{
									isEmpty = false;
								}
							}
						}
					}
				}
				else
				{
					isEmpty = false;
				}
			}
			else
			{
				isEmpty = false;
			}
		}
		if (isEmpty == true)
		{
			if (isVertical == false)
			{
				for (int i = axisX; i < axisX + shipLong[*shipNumber]; i++)
				{
					warArea[findLocation(i, axisY)] = 1;
				}
			}
			if (isVertical == true)
			{
				for (int i = axisY; i < axisY + shipLong[*shipNumber]; i++)
				{
					warArea[findLocation(axisX, i)] = 1;
				}
			}
			*shipNumber += 1;
		}
		else
		{
			placement(warArea, shipLong, shipNumber);
		}
	}
	else
	{
		placement(warArea, shipLong, shipNumber);
	}

}



void shot(int axisX, int *axisY, int* warArea, int* shotDue)
{
	int shotLocation = 0;
	shotLocation = warArea[findLocation(axisX, *axisY)];
	switch (shotLocation)
	{
	case 0:
		cout << "Uzgunum, Karavana" << endl;
		warArea[findLocation(axisX, *axisY)] = 3;
		break;
	case 1:
		cout << "Tebrikler, tam isabet." << endl;
		warArea[findLocation(axisX, *axisY)] = 2;
		break;
	case 2:
	case 3:
	case 4:
		cout << "Buraya zaten daha once atis yapmissin." << endl;
		break;
	}
	*shotDue = *shotDue-1;

}
void shotArea(char koorY, int axisX, int* warArea, int* shotDue,int* axisY)
{
	switch (koorY)
	{
	case 'A':
		*axisY = 0;
		break;
	case 'B':
		*axisY = 1;
		break;
	case 'C':
		*axisY = 2;
		break;
	case 'D':
		*axisY = 3;
		break;
	case 'E':
		*axisY = 4;
		break;
	case 'F':
		*axisY = 5;
		break;
	case 'G':
		*axisY = 6;
		break;
	case 'H':
		*axisY = 7;
		break;
	case 'I':
		*axisY = 8;
		break;
	case 'J':
		*axisY = 9;
		break;
	case 'K':
		*axisY = 10;
		break;
	case 'L':
		*axisY = 11;
		break;
	}
	shot(axisX, axisY, warArea, shotDue);

}

int main()
{
	int warArea[144] = { 0 };
	int shipLong[10] = { 0 };
	int shipAmount = 0;
	int shipNumber = 0;
	int shotDue = 0;
	char koorY = ' ';
	int axisX = -1;
	int axisY = -1;
	int sinkedShip = 0;
	char YKoors[12] = { 'A','B','C','D','E','F','G','H','I','J','K','L' };

	srand(time(0));

	srand(time(0));

	cout << "gemi sayisi giriniz" << endl;
	cin >> shipAmount;
	for (int i = 0; i < shipAmount; i++)
	{
		cout << i + 1 << ". geminin uzunlugunu giriniz.";
		cin >> shipLong[i];
		shotDue += shipLong[i];
	}
	shotDue *= 2;//toplam atis hakki toplam gemi uzunlugunun iki katidir.

	for (int i = 0; i < shipAmount; i++)
	{
		placement(warArea, shipLong, &shipNumber);
	}

	for (int i = 0; i < shotDue; i++)
	{
		cout << "* 0 1 2 3 4 5 6 7 8 9 1 2" << endl;
		for (int j = 0; j < 12; j++)
		{
			cout << YKoors[j];
			for (int k = 0; k < 12; k++)
			{
				/*if (warArea[findLocation(k, j)] == 0 || warArea[findLocation(k, j)] == 1)
				{
					cout << " " << "O";
				}else
				{
					if (warArea[findLocation(k, j)] == 2)
					{
						cout << " " << "I";
					}
					if(warArea[findLocation(k, j)] == 3)
					{
						cout << " " << "K";
					}
				}*/
				cout << " " << warArea[findLocation(k, j)];
			}
			cout << endl;
		}
		cout << "Kalan atis hakkiniz : " << shotDue<<endl;
		cout << "Toplam batirilan gemi sayisi : (" << sinkedShip << "/" << shipAmount << ")" << endl << endl;


		bool isFair = false;
		while (isFair == false)
		{
			
			cout << "Atis yapmak istediginiz koordinatlari belirleyiniz." << endl << "YATAY KOORDINATLAR ICIN 0-11 ARASINDA DEGER GIRINIZ." << endl;
			cout << "DIKEY KOORDINATLAR ICIN BUYUK HARFLERLE A-L ARASINDA DEGER GIRINIZ." << endl<<endl;
			cin >> axisX;
			cin >> koorY;
			if(axisX>-1&&axisX<12)
			{
				for(int i=0;i<12;i++)
				{
					if (koorY == YKoors[i]) 
					{ 
						isFair = true; 
					}
					else
					{
						if (i == 11&&isFair==false)
						{
							cout << "!!!!!   GIRDIGINIZ KOORDINATLAR OYUN ALANINI ICERMEMEKTEDIR   !!!!!!" << endl;
							cout << "LUTFEN GIRDIGINIZ DIKEY KOORDINATLARI KONTROL EDINIZ." << endl<<endl;
						}
					}
				}
			}
			else
			{
				cout << "!!!!!   GIRDIGINIZ KOORDINATLAR OYUN ALANINI ICERMEMEKTEDIR   !!!!!!" << endl;
				cout << "LUTFEN GIRDIGINIZ YATAY KOORDINATLARI KONTROL EDINIZ." << endl<<endl;
			}
		}
		shotArea(koorY, axisX, warArea, &shotDue,&axisY);
		shipControl(axisX, axisY, warArea, &sinkedShip);
														

	}


}
