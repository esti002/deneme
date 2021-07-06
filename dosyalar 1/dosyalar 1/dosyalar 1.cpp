#include <iostream>
#include <fstream>
#include <string>
#include <cstdlib>
#include <iomanip>

using namespace std;

void productManager();

void readFile(fstream& file, int* id, char name[21], int* stockAmount, float* price)
{
	file >> *id;
	file >> name;
	file >> *stockAmount;
	file >> *price;
}
int compareId(fstream& file, int* id)
{
	int t_id = 0;
	int lineNumber = 1;
	char t_line[21];
	while (!file.eof())
	{
		file >> t_id;
		if (t_id == *id)
		{
			return lineNumber;
		}
		file >> t_line;
		file >> t_line;
		file >> t_line;

		lineNumber++;
	}
	return 0;
}

int compareId(fstream& file, int* id, int* t_id)
{
	*t_id = 0;
	int lineNumber = 1;
	string t_line;
	while (!file.eof())
	{
		file >> *t_id;
		if (*t_id == *id)
		{
			return lineNumber;
		}

		file >> t_line;
		file >> t_line;
		file >> t_line;
		lineNumber++;
	}
	return 0;
}

void addProduct(fstream& file)
{
	int n_id = 0;
	char n_name[21];
	int n_stockA = 0;
	float n_price = 0;
	bool isConvenient = false;
	while (isConvenient == false)
	{
		cout << "Gireceginiz urunun urun numarasini girniz." << endl;
		cin >> n_id;
		if (compareId(file, &n_id) == 0)
		{
			isConvenient = true;
		}
		else
		{
			cout << "Girdiginiz urun numarasi daha once kullanilmis lutfen yeni bir urun numarasi girin." << endl;
		}
		file.close();
		fstream file("urunler.txt", std::ios::in | ios::out | ios::app);
		file << endl;
		file << n_id << " ";//su anda bunlari dosyaya kaydetmiyor onun sebebi de end of file fonksiyonunun dosya sonuna kadar gitmesi
		cout << "Yeni urununuzun adini giriniz." << endl;
		cin >> n_name;
		file << n_name << " ";
		cout << "Yeni urununuzun stok miktarini giriniz." << endl;
		cin >> n_stockA;
		file << n_stockA << " ";
		cout << "Yeni urununuzun fiyatini belirleyiniz." << endl;
		cin >> n_price;
		file << n_price << endl;
		cout << "kayit edildi.";
		file.close();
	}
}

void updatePrice(fstream& file)
{
	float n_price = 0;
	int t_id = 0;
	char t_name[21];
	int t_stockA = 0;
	int t_lineNo = 1;
	int tmp_id = 0;
	file.clear();
	file.seekg(0);

	cout << "Fiyatini degistirmek istediginiz urunun urun numarasini giriniz." << endl;
	cin >> t_id;
	fstream tempPrice("tempPrice.txt", std::ios::in | ios::out | ios::app);
	if (compareId(file, &t_id) != 0)
	{
	file.clear();
	file.seekg(0);
	int lineNo = compareId(file, &t_id, &tmp_id);
	file.clear();
	file.seekg(0);
		while (!file.eof())
		{
			if (lineNo > 0)
			{
				bool isOK = false;
				if (lineNo == t_lineNo&&isOK==false)
				{
					isOK = true;
					char temp_price[21];
					cout << t_id << " urun numarali urununuzun yeni fiyatini giriniz." << endl;
					cin >> n_price;

					file >> t_id >> t_name >> t_stockA >> temp_price;
					tempPrice << t_id << " " << t_name << " " << t_stockA << " " << n_price << endl;
				}
				else
				{
					if (!file.eof())
					{
						file >> tmp_id;
					}
					if (!file.eof())
					{
						file >> t_name;
					}
					if (!file.eof())
					{
						file >> t_stockA;
					}
					if (!file.eof())
					{
						file >> n_price;
						tempPrice << tmp_id << " " << t_name << " " << t_stockA << " " << n_price << endl;
					}
					
				}
			}
			t_lineNo++;

		}
	}
	else
	{
		cout << "Girdiginiz urun numarasi ile kayitli bir urun bulunmamaktadir." << endl << endl;
		updatePrice(file);
	}
}

void priceManager(fstream &file)
{
	updatePrice(file);
	file.close();
	remove("urunler.txt");
	rename("tempPrice.txt","urunler.txt");
}

void updateStock(fstream &file)
{
	int t_id = 0;
	int tmp_id = 0;
	string t_name;
	int t_stockA = 0;
	float t_price = 0;
	int lineNO = 0;

	fstream tempStock("tempStock.txt",std::ios::in|ios::out|ios::app);

	cout << "Stok miktarina ekleme yapacaginiz urunun urun numarasini giriniz." << endl;
	cin >> t_id;

	file.clear();
	file.seekg(0);

	lineNO = compareId(file,&t_id);
	file.clear();
	file.seekg(0);
	
	if (lineNO > 0)
	{
		int addStock;
		cout << t_id << " urun numarali urunun stok miktarina yapmak istediginiz stok miktarini giriniz." << endl;
		cin >> addStock;
		int t_lineNo = 1;
		while (!file.eof())
		{
			bool isOK = true;
			if(!file.eof()&& isOK ==true)
			{
				file >> tmp_id;
			}
			else 
			{
				isOK = false;
			}
			if (!file.eof() && isOK == true)
			{
				file >> t_name;
			}
			else
			{
				isOK = false;
			}
			if (!file.eof() && isOK == true)
			{
				file >> t_stockA;
			}
			else
			{
				isOK = false;
			}
			if (!file.eof() && isOK == true)
			{
				file >> t_price;
			}
			else
			{
				isOK = false;
			}
			if(t_lineNo==lineNO && isOK == true)
			{
				tempStock << t_id << " " << t_name << " " << t_stockA + addStock << " " << t_price << endl;
			}
			if (t_lineNo != lineNO && isOK == true)
			{
				tempStock << tmp_id << " " << t_name << " " << t_stockA << " " << t_price << endl;
			}
			t_lineNo++;
		}
	}
	else
	{
		cout << endl <<"Girmis oldugunuz urun numarasina ait bir urun bulunamadi." << endl;
		updateStock(file);
	}
}

void stockManager(fstream &file)
{
	updateStock(file);
	file.close();
	remove("urunler.txt");
	rename("tempStock.txt", "urunler.txt");
}

void removeProduct(fstream &file)
{
	int t_id = 0;
	string t_name;
	int t_stockA = 0;
	float t_price = 0;
	int lineNO = 0;

	file.clear();
	file.seekg(0);
	cout << "Tum bilgilerini silmek istediginiz urunun urun numarasini giriniz." << endl;
	cin >> t_id;
	lineNO = compareId(file, &t_id);
	file.clear();
	file.seekg(0);

	fstream tempRemove("tempRemove.txt", std::ios::in | ios::out | ios::app);

	if(lineNO>0)
	{
		int t_lineNo = 1;
		bool isOK = true;
		while (!file.eof())
		{
			file >> t_id;
			if(!file.eof())
			{
				file >> t_name;
			}

			else { isOK = false; }
			if (!file.eof())
			{
				file >> t_stockA;
			}
			else { isOK = false; }
			if (!file.eof())
			{
				file >> t_price;
			}
			else { isOK = false; }
			if(lineNO!=t_lineNo&&isOK==true)
			{
				tempRemove << t_id << " " << t_name << " " << t_stockA << " " << t_price << endl;
			}

			t_lineNo++;
		}
	}
	else
	{
		cout << "Girmis oldugunuz urun numarasi ile kayitli bir urun bulunamadi." << endl;
		removeProduct(file);
	}

}

void removeManager(fstream &file)
{
	removeProduct(file);
	file.close();
	remove("urunler.txt");
	rename("tempRemove.txt", "urunler.txt");
}

void updateStock2(fstream &file,int *t_id,int changeAmount,int t_stockA)
{
	int tmp_id = 0;
	string t_name;
	float t_price = 0;
	int lineNO = 0;

	fstream tempStock("tempstock.txt", std::ios::in | ios::out | ios::app);

	file.clear();
	file.seekg(0);
	lineNO = compareId(file, t_id);
	file.clear();
	file.seekg(0);

	if(lineNO>0)
	{
		int t_lineNo = 1;
		while(!file.eof())
		{
			bool isOK = true;
			if (!file.eof() && isOK == true)
			{
				file >> tmp_id;
			}
			else
			{
				isOK = false;
			}
			if (!file.eof() && isOK == true)
			{
				file >> t_name;
			}
			else
			{
				isOK = false;
			}
			if (!file.eof() && isOK == true)
			{
				file >> t_stockA;
			}
			else
			{
				isOK = false;
			}
			if (!file.eof() && isOK == true)
			{
				file >> t_price;
			}
			else
			{
				isOK = false;
			}
			if (t_lineNo == lineNO && isOK == true)
			{
				if (t_stockA < changeAmount)
				{
					cout << "Bu kadar urun yok yani bu kadar satis yapmaniz imkansiz." << endl << endl;
					tempStock.close();
					productManager();
				}
				tempStock << *t_id << " " << t_name << " " << t_stockA + changeAmount*-1 << " " << t_price << endl;
			}
			if (t_lineNo != lineNO && isOK == true)
			{
				tempStock << tmp_id << " " << t_name << " " << t_stockA << " " << t_price << endl;
			}
			t_lineNo++;
		}
	}
	tempStock.close();
}

void sellProcess(fstream &productFile,fstream &saleFile) 
{
	int sale_id = 0;
	int date_day = 0, date_month = 0, date_year = 0;
	int saleAmount = 0;
	int stockA = 0;
	productFile.clear();
	productFile.seekg(0);
	bool isOK = true;
	while (isOK == true)
	{
		cout << "Satisi yapilan urunun urun numarasini giriniz." << endl;
		cin >> sale_id;
		if(compareId(productFile,&sale_id)==0)
		{
			cout << "Girmis oldugunuz urun numarasi urunler arasinda bulunmamaktadir." << endl;
			isOK = true;
		}
		else
		{
			isOK = false;
		}
		productFile.clear();
		productFile.seekg(0);
	}
	isOK = true;
	while (isOK == true)
	{
		cout << "Satis tarihini sirayla GUN AY YIL seklinde giriniz." << endl;
		cin >> date_day >> date_month >> date_year;
		if(date_day<1||date_day>31||date_month<1||date_month>12||date_year<0||date_year>99)
		{
			cout << "Girmis oldugunuz tarih gecersiz." << endl;
			isOK = true;
		}
		else
		{
			isOK = false;
		}
	}
	isOK = true;
	productFile.clear();
	productFile.seekg(0);
	while (isOK == true)
	{
		cout << "Yapilan satis miktarini giriniz." << endl;
		cin >> saleAmount;
		if(saleAmount <= 0)
		{
			cout << saleAmount << " tane urun satmaniz mumkun degil." << endl;
			isOK = true;
		}
		else
		{
			isOK = false;
		}
	}
	productFile.clear();
	productFile.seekg(0);

	updateStock2(productFile, &sale_id, saleAmount, stockA);
	productFile.close();
	remove("urunler.txt");
	rename("tempStock.txt","urunler.txt");

	saleFile.app;
	saleFile << sale_id << " " << date_day << date_month << date_year << " " << saleAmount << endl;
	cout << "Satislar kaydedildi." << endl << endl;
}

void showInfos(fstream& productFile, fstream& saleFile, bool allProducts ,bool id = 0, bool name = 0, bool stockA = 0, bool price = 0, bool date = 0, bool sellA=0)
{
	int lineNO = 0;
	int idNO = 0;
	int tmp_id = 0;
	string t_name;
	float t_price = 0;
	int t_stockA = 0;
	if (allProducts == false)
	{
		cout << "Ekrana urun ve satis bilgilerinin gelmesini istediginiz urunun urun numarasini giriniz." << endl;
		cin >> idNO;
	}
	lineNO = compareId(productFile, &idNO);
	productFile.clear();
	productFile.seekp(0);

	bool showProducts = false;
	bool showSales = false;
	if(id != 0 ||name != 0 ||stockA != 0 ||price != 0 )
	{
		showProducts = true;
	}
	if(date != 0 || sellA != 0 )
	{
		showSales = true;
	}
	cout << setw(20) << left;
	if(showProducts==true)
	{
		if(id != 0)
		{
			cout << setw(20) << "URUN KODU";
		}
		if (name != 0)
		{
			cout << setw(20) << "URUN ADI";
		}
		if (price != 0)
		{
			cout << setw(20) << "URUN FIYATI";
		}
		if (id != 0)
		{
			cout << setw(20) <<"URUN STOK MIKTARI";
		}
		cout << endl;
		int t_lineNo = 1;
		while(!productFile.eof())
		{
			bool isOK = true;
			if (!productFile.eof() && isOK == true)
			{
				productFile >> tmp_id;
			}
			else
			{
				isOK = false;
			}
			if (!productFile.eof() && isOK == true)
			{
				productFile >> t_name;
			}
			else
			{
				isOK = false;
			}
			if (!productFile.eof() && isOK == true)
			{
				productFile >> t_stockA;
			}
			else
			{
				isOK = false;
			}
			if (!productFile.eof() && isOK == true)
			{
				productFile >> t_price;
			}
			else
			{
				isOK = false;
			}
			if (t_lineNo == lineNO && isOK == true && allProducts == false)
			{
				if (id != 0)
				{
					cout << setw(20) << tmp_id ;
				}
				if (name != 0)
				{
					cout << setw(20) << t_name ;
				}
				if (price != 0)
				{
					cout << setw(20) << t_price ;
				}
				if (id != 0)
				{
					cout << setw(20) << t_stockA ;
				}
				cout << endl << endl;
			}
			if(allProducts==true && isOK == true)
			{
				if (id != 0)
				{
					cout << setw(20) << tmp_id ;
				}
				if (name != 0)
				{
					cout << setw(20) << t_name ;
				}
				if (price != 0)
				{
					cout << setw(20) << t_price ;
				}
				if (id != 0)
				{
					cout << setw(20) << t_stockA ;
				}
				cout << endl << endl;
			}
			t_lineNo++;
		}
	}

	if(showSales==true)
	{
		int t_date = 0;
		int t_sellA = 0;
		int t_lineNO = 0;
		t_lineNO = compareId(saleFile, &idNO);
		if(allProducts==true)
		{
			t_lineNO = 1;
		}
		saleFile.clear();
		saleFile.seekg(0);
		if(t_lineNO==0)
		{
			cout << idNO << " urun numarali urunun hicbir satis kaydi bulunmamaktadir." << endl<<endl;
		}
		if (date != 0)
		{
			cout << setw(20) << "SATIS TARIHI";
		}
		if (sellA != 0)
		{
			cout << setw(20) << "SATIS MIKTARI";
		}
		cout << endl;
		if(t_lineNO>0 )
		{
			while(!saleFile.eof())
			{
				bool isOK = true;
				if (!saleFile.eof() && isOK == true)
				{
					saleFile >> tmp_id;
				}
				else
				{
					isOK = false;
				}
				if (!saleFile.eof() && isOK == true)
				{
					saleFile >> t_date;
				}
				else
				{
					isOK = false;
				}
				if (!saleFile.eof() && isOK == true)
				{
					saleFile >> t_sellA;
				}
				else
				{
					isOK = false;
				}
				if(!saleFile.eof() && tmp_id==idNO&&allProducts==false&&isOK==true)
				{

					if (date != 0)
					{
						cout << setw(20) << t_date;
					}
					if (sellA != 0)
					{
						cout << setw(20) << t_sellA;
					}
					cout << endl;
				}
				if (allProducts == true && isOK == true)
				{
					if (date != 0)
					{
						cout << setw(20) << t_date;
					}
					if (sellA != 0)
					{
						cout << setw(20) << t_sellA;
					}
					cout << endl;
				}

			}
		}
	}
}

void stockLessX(fstream &file)
{
	int productsAmount[100] = { 0 };
	int t_id = 0;
	string t_name;
	int t_stockA = 0;
	float t_price = 0;
	int minStock = 0;

	cout << "Gosterilmesini istediginiz stok miktarinin en yuksek seviyesini giriniz." << endl;
	cin >> minStock;
	bool isOK = true;

	cout << setw(20) << left;
	for(int i =0;i<100;i++)
	{	
		if (!file.eof() && isOK == true)
		{
			file >> t_id;
		}
		else
		{
			isOK = false;
		}
		if (!file.eof() && isOK == true)
		{
			file >> t_name;
		}
		else
		{
			isOK = false;
		}
		if (!file.eof() && isOK == true)
		{
			file >> t_stockA;
		}
		else
		{
			isOK = false;
		}
		if (!file.eof() && isOK == true)
		{
			file >> t_price;
		}
		else
		{
			isOK = false;
		}
		if(minStock>t_stockA&&isOK==true)
		{
			cout << setw(20) << "URUN KODU" << setw(20) << "URUN ADI" << setw(20) << "STOK MIKTARI" << endl;
			cout << setw(20) << t_id << setw(20) << t_name << setw(20) << t_stockA << endl;

		}
		if(isOK==false)
		{
			break;
		}
	}
}

void giroManager(fstream &productsFile, fstream &salesFile)
{
	
}

void productManager()
{
	int projectInput = 0;

	cout << "Yapmak istediginiz islem numarasini giriniz." << endl;
	cout << "1) Yeni bir urunun eklenmesi " << endl;
	cout << "2) Bir urunun fiyatinin guncellenmesi " << endl;
	cout << "3) Stoka urun girisi yapilmasi" << endl;
	cout << "4) Yapilan satislarin sisteme girilmesi " << endl;
	cout << "5) Bir urunun silinmesi " << endl;
	cout << "6) Bir urunun bilgilerinin ve satis kayitlarinin listelenmesi " << endl;
	cout << "7) Bir urunun bilgilerinin listelenmesi " << endl;
	cout << "8) Tum urunlerin listelenmesi " << endl;
	cout << "9) Belirli bir stok miktarinin altindaki urunlerin listelenmesi" << endl;
	cout << "10) En cok ve en az satilan ve ciro getiren urunlerin bulunmasi" << endl;
	cout << "0) Cikis" << endl;
	cin >> projectInput;

	fstream condition("urunler.txt", std::ios::in | ios::out); //urun bilgilerini tutan dosya "condition durum kosul sart falan demek" 
	fstream sales("satislar.txt", std::ios::in | ios::out | ios::app); //yapilan satislarin tutuldugu dosya
	switch (projectInput)
	{
	case 1:
		addProduct(condition);
		break;
	case 2:
		priceManager(condition);
		break;
	case 3:
		stockManager(condition);
		break;
	case 4:
		sellProcess(condition, sales);
		break;
	case 5:
		removeManager(condition);
		break;
	case 6:
		showInfos(condition, sales,0, 1, 1, 1, 1, 1, 1);
		break;
	case 7:
		showInfos(condition, sales, 0, 1, 1, 1, 1);
		break;
	case 8:
		showInfos(condition, sales, 1, 1, 1, 1, 1, 1, 1);
		break;
	case 9:
		stockLessX(condition);
		break;
	case 10:

		break;
	case 0:
		condition.clear();
		condition.close();
		sales.close();
		exit(0);
		break;
	}
	if (condition.is_open())
	{
		condition.clear();
		condition.close();
	}
	sales.close();
	productManager();

}

int main()
{
	productManager();

}