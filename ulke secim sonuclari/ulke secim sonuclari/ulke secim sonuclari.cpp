#include <iostream>
#include <fstream>
#include <iomanip>
#include <stdlib.h>

using namespace std;

template <typename T>
void sirala(T* dizi, T* yeniSira)
{
    T enBuyuk = dizi[0];
    for (int i = 0; i < 8; i++) { if (dizi[i] > enBuyuk) { enBuyuk = dizi[i]; } }
    T geciciDizi[8];
    for (int i = 0; i < 8; i++) 
    {
        geciciDizi[i] = dizi[i];
    }
    for (int i=0;i<7;i++)
    {
        enBuyuk = geciciDizi[i];
        for(int j=i+1;j<8;j++)
        {
            if(enBuyuk<geciciDizi[j])
            {
                T temp = enBuyuk;
                enBuyuk = geciciDizi[j];
                geciciDizi[j] = geciciDizi[i];
                geciciDizi[i] = enBuyuk;
                T tempSira = yeniSira[i];
                yeniSira[i] = yeniSira[j];
                yeniSira[j] = tempSira;
            }
        }
    }
}
template<typename T>
int enBuyuk(T *dizi)
{
    int buyuk = dizi[0];
    int buyukIndex=0;
    for (int i = 0; i < 8; i++) 
    {
        if(buyuk<dizi[i])
        {
            buyuk = dizi[i];
            buyukIndex = i;
        }
    }
    return buyukIndex;
}

void yuzdeHesap(int *oylar,int toplamOy,float *oyYuzdeleri)
{
    float temp = 100;
    float katSayi = temp/toplamOy;
    for (int i = 0; i < 8; i++)
    {
        oyYuzdeleri[i] = katSayi * oylar[i];
    }
}
void vekilHesap(float *oyYuzdeleri,int vekilKont,int *vekilSayilari) 
{
    float geciciDizi[8] = { 0 };
    for(int i=0;i<8;i++)
    {
        geciciDizi[i] = oyYuzdeleri[i];
    }
    for (int i = 0; i < vekilKont; i++)
    {
        int buyuk = enBuyuk(geciciDizi);
        geciciDizi[buyuk] = geciciDizi[buyuk] / 2;
        vekilSayilari[buyuk]++;

    }
}

int main()
{
    char partiler[8] = { 'A','B','C','D','E','F','G','H' };
    //partilerin degiskenleri
    int partiOylari[8] = { 0 };
    float oyYuzdeleri[8] = { 0 };
    float oyYuzdeleriToplam[8] = { 0 };
    int vekilSayilari[8] = { 0 };
    int toplamVekilSayilari[8] = { 0 };
    int toplamOylar[8] = { 0 };
    int yeniSira[8] = { 0,1,2,3,4,5,6,7 };
    float MVYuzde[8] = { 0 };
    int Siralamasi[8] = {0};
    int ilBirincilikleri[8] = { 0 };
    //il kayitlari
    int plakaNo = 0,i_vekilKont = 0, i_gecerliOy = 0;

    //ulke kayitlari
    int u_vekilKont = 0, u_gecerliOy = 0;
    float u_vekilYuzde = 0;

    fstream dosya("new document.dat", std::ios::in | ios::out);
    if(!dosya.is_open())
    {
        cout<<"Uzgunum ama dosya acilamadi. Lutfen dosyayi kontrol edip programi yeniden baslatiniz."<<endl;
            exit(0);
    }
    while (!dosya.eof())
    {
        for (int i = 0; i < 8; i++) 
        {
            yeniSira[i] = i;
            vekilSayilari[i] = 0;
        }
        int plakaNo = 0, i_vekilKont = 0, i_gecerliOy = 0;
        dosya >> plakaNo >> i_vekilKont;
        u_vekilKont += i_vekilKont;
        for (int i = 0; i < 8; i++)
        {
            dosya >> partiOylari[i];
            i_gecerliOy += partiOylari[i];
            toplamOylar[i] += partiOylari[i];
        }
        u_gecerliOy += i_gecerliOy;
        sirala(partiOylari,yeniSira);
        yuzdeHesap(partiOylari, i_gecerliOy, oyYuzdeleri);
        vekilHesap(oyYuzdeleri, i_vekilKont, vekilSayilari);
        for(int i=0;i<8;i++){
            toplamVekilSayilari[i] += vekilSayilari[i];
        }

        cout << "Il plaka kodu : " << plakaNo << endl << "Milletvekili  kontenjani : " << i_vekilKont << endl << "Gecerli oy sayisi : " << i_gecerliOy<<endl;
        cout << setw(10) << "" << "OY SAYISI" << setw(10) << "" << "OY YUZDESI" << setw(10) << "" << "MV SAYISI"<<endl;
        cout << setw(10) << "" << "---------" << setw(10) << "" << "----------" << setw(10) << "" << "---------"<<endl;
        for (int i = 0; i < 8; i++)
        {
            int j = yeniSira[i];
            cout << partiler[j] << " partisi" << setw(10) <<partiOylari[j] << setw(10) << "" << setw(10) << oyYuzdeleri[j] << setw(15) << vekilSayilari[j]<<endl;
        }

        ilBirincilikleri[yeniSira[0]]++;
        cout << endl<< "Devam etmek icin bir tusa basin..." << endl;
        cin >> plakaNo;
        cout << endl << endl;
    }
    cout << "Turkiye geneli" << endl << "Toplam milletvekili kontenjani : " << u_vekilKont << endl << "Toplam gecerli oy sayisi : " << u_gecerliOy << endl;
    cout << setw(10) << "" << "OY SAYISI" << setw(10) << "" << "OY YUZDESI" << setw(10) << "" << "MV SAYISI" << setw(10) << "MV ORANI" << endl;
    cout << setw(10) << "" << "---------" << setw(10) << "" << "----------" << setw(10) << "" << "---------" << setw(10) << "--------" << endl<<endl;
    yuzdeHesap(toplamOylar, u_gecerliOy, oyYuzdeleriToplam);
    yuzdeHesap(toplamVekilSayilari, u_vekilKont, MVYuzde);
    for (int i = 0; i < 8; i++)
    {
        cout << partiler[i] << " partisi" << setw(10) << toplamOylar[i] << setw(10) << "" << setw(10) << oyYuzdeleriToplam[i] << setw(15) << toplamVekilSayilari[i] << setw(15) << MVYuzde[i] << endl;
    }
    for (int i = 0; i < 8; i++)
    {
        yeniSira[i] = i;
    }
    cout << endl << endl;
    sirala(toplamVekilSayilari, yeniSira);
    cout << "Iktidar partisi : " << partiler[yeniSira[0]] << endl << "Ana muhalefet partisi : " << partiler[yeniSira[1]] << endl<<endl;
    cout << "Partilerin oy sayilarina gore toplam il birincilikleri : " << endl;
    for (int i = 0; i < 8; i++)
    {
        if (ilBirincilikleri[i] > 0) 
        {
            cout << partiler[yeniSira[i]] << " partisi : " << ilBirincilikleri[i] << endl;
        }
    }
    dosya.close();
}
