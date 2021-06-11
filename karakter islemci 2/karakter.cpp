#include <iostream>
#include <fstream>

#define stdSpace 81


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

int wordAmount(fstream &dosya,int *charNo,int *remainSpace,int lineLong)
{
	int L_TLong;
	if (lineLong >= 40 && lineLong <= 80)
	{
		L_TLong = lineLong + 1;
	}else
	{
		L_TLong = stdSpace;
	}
	int L_Tspace = L_TLong;//satirdaki kalacak toplam bosluk 
	int L_Tchar = 0;//satirdaki toplam karakter sayisi
	int L_Tword = 0;//satirdaki toplam kelime sayisi
	char word[21];//her turda alinacak max 20 karakterli kelime
	dosya.seekg(*charNo);
	*remainSpace = 0;
	while (!dosya.eof()) 
	{
		dosya >> word;
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

void justify(fstream &dosya,int lineLong)
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
	char word[21];//ekrana cikacak kelime
	while (!dosya.eof())
	{
		lineNO++;
		Tword = 0;
		Tchar = 0;
		willWrite = wordAmount(dosya, WA_charNo,remainSpace,lineLong);
		dosya.seekg(NL_charNo);
		for (int i = 0; i < willWrite;i++)
		{
			dosya >> word;
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
			while (!dosya.eof()) {
				dosya >> word;
				cout << word << " ";
			}
		}
		cout << endl;
		NL_charNo += Tchar+1;
	}
}

int main()
{
	int lineLong = 0;
	cout << "40 ile 80 arasinda olan her bir satirin olmasini istediginiz uzunluk degerini giriniz." << endl;
	cin >> lineLong;
	fstream dosya("trying.txt", std::ios::in | ios::out);


	justify(dosya, lineLong);



}