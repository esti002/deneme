#include <iostream>
#include <fstream>
#include <string>
#include <cstdlib>


using namespace std;

void readFile(fstream& file, int* id, char name[21], int* stockAmount, float* price)
{
	file >> *id;
	file >> name;
	file >> *stockAmount;
	file >> *price;
}

/*bool compareId(fstream& file, int* id = 0)
{
	string satir;
	int temp1 = 0;
	while (!file.eof())
	{
		file >> temp1;
		file >> satir;
		if (*id == temp1)
		{
			return true;
		}
	}
	return false;
}*/

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
	fstream tempFile("tempFile.txt", std::ios::in | ios::out | ios::app);
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
					tempFile << t_id << " " << t_name << " " << t_stockA << " " << n_price << endl;
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
						tempFile << tmp_id << " " << t_name << " " << t_stockA << " " << n_price << endl;
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
	rename("tempFile.txt","urunler.txt");
}

void updateStock(fstream &file)
{
	int t_id = 0;
	string t_name;
	int t_stockA = 0;
	int t_price = 0;
	int lineNO = 0;

	cout << "Stok miktarina ekleme yapacaginiz urunun urun numarasini giriniz." << endl;
	cin >> t_id;

	file.clear();
	file.seekg(0);

	lineNO = compareId(file,&t_id);

	while(!file.eof())
	{
		
	}

}

void productManager()
{
	int id = 0;
	char name[21];
	int stockAmount = 0;
	int price = 0;
	int projectInput = 0;

	cout << "Yapmak istediginiz islem numarasini giriniz." << endl;
	cout << "1) Yeni bir urunun eklenmesi " << endl;
	cout << "2) Bir urunun fiyatinin guncellenmesi " << endl;
	cout << "3) Stoka urun girisi yapilmasi" << endl;
	cout << "4) Yapılan satislarin sisteme girilmesi " << endl;
	cout << "5) Bir urunun silinmesi " << endl;
	cout << "6) Bir urunun bilgilerinin ve satis kayitlarinin listelenmesi " << endl;
	cout << "7) Bir urunun bilgilerinin listelenmesi " << endl;
	cout << "8) Tum urunlerin listelenmesi " << endl;
	cout << "9) Belirli bir stok miktarinin altindaki urunlerin listelenmesi" << endl;
	cout << "10) En cok ve en az satilan ve ciro getiren urunlerin bulunmasi" << endl;
	cout << "0) Cikis" << endl;
	cin >> projectInput;

	fstream condition("urunler.txt", std::ios::in | ios::out); //urun bilgilerini tutan dosya "condition durum kosul sart falan demek" 
	fstream sales("satislar.dat", std::ios::in | ios::out | ios::app);//yapilan satislarin tutuldugu dosya
	switch (projectInput)
	{
	case 1:
		addProduct(condition);
		break;
	case 2:
		priceManager(condition);
		break;
	case 3:

		break;
	case 4:

		break;
	case 5:

		break;
	case 6:

		break;
	case 7:

		break;
	case 8:

		break;
	case 9:

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