#include <iostream>
#include <fstream>
#include <iomanip>
#include <cstdlib>

#define stdSpace 81//her satir icin verilen standart uzunluk degeri
#define defaultWC 21//varsayilan kelime karakteri

using namespace std;

int spaceApp(int *remainSpace,int lineNo,int willWrite,int Tword)//UNUTMAMAK ICIN ACIKLAMA==> satirda kullanilacak toplam bosluk sayisini kac farkli bosluk var(kelime-1) 
{                                                      //kismina bolup her kelime arasina kac bosluk geldigine bak. ardindan toplam bosluk sayisi % (kelime-1) yaparak
													   //kac tane arttigini bul. sonra satir sayisi %2 ile sagdan mi soldan mi olduguna bak	
													   
													   //ORNEGIN  artiklar sagdan baslayacak o zaman (kelime-1)-artiklar >0 oldugu surece hepsine dusen kadar dagitsin
													   //YA DA soldan baslarsa zaten o zaman for dongusu ile artiklar bitene kadar hepsine dusen +1 seklinde dagitsin
	int wordBetween = willWrite - 1;
	int paySpace = *remainSpace / wordBetween;
	int extraSpace = *remainSpace % wordBetween;

	if(lineNo%2==0)
	{
		if(wordBetween-Tword>extraSpace)
		{
			return paySpace;
		}
		else 
		{
			return paySpace + 1;
		}
	}else
	{
		extraSpace -= Tword;
		if(extraSpace>0)
		{
			return paySpace + 1;
		}else
		{
			return paySpace;
		}
	}
}

int wordAmount(fstream &file,int *charNo,int *remainSpace,int lineLong)
{
	int L_TLong;
	if (lineLong >= 40 && lineLong <= 80)
	{
		L_TLong = lineLong + 1;
	}else
	{
		if (*charNo == 0) 
		{
			cout << "Girmis oldugunuz deger 40 ile 80 arasinda bir deger degil. "<<endl<<"Bundan dolayi satir uzunluk degeri varsayilan deger olan 80 olarak atandi." << endl<<endl;
		}
		L_TLong = stdSpace;
	}
	int L_Tspace = L_TLong;//satirdaki kalacak toplam bosluk 
	int L_Tchar = 0;//satirdaki toplam karakter sayisi
	int L_Tword = 0;//satirdaki toplam kelime sayisi
	char word[defaultWC];//her turda alinacak max 20 karakterli kelime
	file.seekg(*charNo);
	*remainSpace = 0;
	while (!file.eof())
	{
		file >> word;
		if(L_Tword>1)//eger bir kelimeden fazla kelime okuduysa onlar arasinda zaten bir bosluk olmali bu da onun kosulu
		{
			L_Tspace--;
			*remainSpace = *(remainSpace) +1;
		}
		if(strlen(word) < L_Tspace)
		{
			L_Tspace = L_TLong;
			L_Tchar += strlen(word);
			if (L_Tword > 0)
			{
				L_Tchar++;
			}
			L_Tword++;
			L_Tspace -= L_Tchar;
		}else
		{
			L_Tspace = L_TLong;
			L_Tspace -= L_Tchar+1;	
			*remainSpace += L_Tspace;
			*charNo += L_Tchar+1;
			return L_Tword;
		}
	}
	return 0;
}

void justify(fstream & file)
{
	int wa_char = 0;//word amound fonksiyonunun devam edecegi karakter numarasi
	int* WA_charNo = &wa_char;
	int NL_charNo = 0;//justify(NL=> New Line) fonksiyonunun devam edecegi karakter numarasi
	int Tbosluk = 0;//toplam bosluk
	int Tchar = 0;//toplam karakter
	int lineNO = 0;//satir numarasi
	int Tword = 0;//her turda girilmis olan kelime sayisi
	int willWrite = 0;//kac kelime yazilacagii tutan degisken
	int Rspace = 0;//her satida kelimeler yazildiktan sonra kalan bosluk sayisi
	int* remainSpace = &Rspace;
	char word[defaultWC];//ekrana cikacak kelime
	int lineLong = 0;
	cout << "40 ile 80 arasinda olan her bir satirin olmasini istediginiz uzunluk degerini giriniz." << endl;
	cin >> lineLong;
	file.seekg(0);
	while (!file.eof())
	{
		lineNO++;
		Tword = 0;
		Tchar = 0;
		willWrite = wordAmount(file, WA_charNo,remainSpace,lineLong);
		file.seekg(NL_charNo);
		for (int i = 0; i < willWrite;i++)
		{
			file >> word;
			cout << word ;
			for (int j = 0; j < spaceApp(remainSpace, lineNO, willWrite, Tword); j++)
			{
				if (i!=willWrite-1)
				{
					cout << " ";
				}
			}
			
			Tword++;  
			
			if(Tword>1)
			{
				Tchar += strlen(word) + 1;
			}else
			{
				Tchar += strlen(word);
			}
		}
		if (willWrite == 0)
		{
			while (!file.eof()) {
				file >> word;
				cout << word << " ";
			}
		}
		cout << endl;
		NL_charNo += Tchar+1;
	}
}

void searchWord(fstream& file)
{
	int wordLocation = 0; //dosya icindeki kelime gezzgininin konumu
	int charLocation = 0; //dosya icindeki karakter gezgininin konumu
	char search[defaultWC]; //aranacak kelime
	char fileWord[defaultWC]; //dosyadan cekilen kelime
	char fileChar; //dosyadan teker teker cekilen karakter
	int totalUsing = 0;

	cout << "Aranacak kelimeyi giriniz." << endl;
	cin >> search;
	cout << search << " kelimesinin yer aldigi kelimeler : " << endl << endl;
	cout << "            KELIMELER           KONUM      " << endl;
	cout << "      --------------------    ---------    " << endl;
	while (!file.eof())
    {
	charLocation = wordLocation;
	file.seekg(wordLocation);
	file >> fileWord;

	if (strlen(fileWord) >= strlen(search))
	{
		for (int i = 0; i < strlen(fileWord); i++)
		{

			int isItFit = 0;
			file.seekg(charLocation);
			file >> fileChar;
			charLocation++;

			if (fileChar == search[0])
			{
				isItFit++;
				for (int j = 1; j < strlen(search); j++)
				{
					file >> fileChar;
					if (fileChar == search[j])
					{
						isItFit++;
					}
					else { break; }
					if (isItFit == strlen(search))
					{
						file.setf(ios_base::left);             
						cout << setw(19) << fileWord << setw(16) << wordLocation + 1 << endl;
						totalUsing++;
					}
				}
			}
		}
	}
	wordLocation += strlen(fileWord) + 1;
	}
	cout << endl << " Toplam tekrar sayisi : " << totalUsing << endl << endl;
}

void wordDetails(fstream &file)
{
	int charAmount[20] = { 0 };
	char word[defaultWC];

	while (!file.eof())
	{
		file >> word;
		charAmount[strlen(word)-1]++;
	}

	for (int i = 0; i < 20; i++)
	{
		if (charAmount[i] > 0)
		{
			cout << i + 1 << " karakterden olusan toplamda " << charAmount[i] << " tane kelime var" << endl;
		}
	}
}

void menuControl()
{
	fstream file("trying.txt", std::ios::in | ios::out);
	int menuNo = 0;
	file.seekg(0);
	cout << endl << "Yapmak istediginiz islemin numarasini giriniz." << endl << endl;
	cout << "1. Paragrafi iki yana yaslayarak goruntuleme." << endl
		<< "2. Paragrafta kelime arama." << endl
		<< "3. Kelime uzunlugu istatistikleri." << endl
		<< "4. Cikis" << endl;

	cin >> menuNo;
	if (menuNo > 0 && menuNo < 5)
	{
		switch (menuNo)
		{
		case 1:
			justify(file);
			break;
		case 2:
			searchWord(file);
			break;
		case 3:
			wordDetails(file);
			break;
		case 4:
			exit(0);
			break;
		}
		file.close();
		menuControl();

	}else
	{
		cout << "HATALI NUMARA TUSLADINIZ------TEKRAR DENEYINIZ" << endl << endl;
		file.close();
		menuControl();
	}
}

int main()
{
	menuControl();
}
