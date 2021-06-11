#include <iostream>
#include <fstream>

using namespace std;

int main()
{
    int sayac[9] = { 0 };
    int week; int deger;
    int toplamSayi=0;
    fstream kayit;
    kayit.open("new document.txt", std::ios::in | ios::out);

    while(!kayit.eof())
    {
        toplamSayi++;
        kayit >> week;
        kayit >> deger;
        switch (deger)
        {
        case 1:
            sayac[0]++;
            break;
        case 2:
            sayac[1]++;
            break;
        case 3:
            sayac[2]++;
            break;
        case 4:
            sayac[3]++;
            break;
        case 5:
            sayac[4]++;
            break;
        case 6:
            sayac[5]++;
            break;
        case 7:
            sayac[6]++;
            break;
        case 8:
            sayac[7]++;
            break;
        case 9:
            sayac[8]++;
            break;
        }

    }
    int enBuyuk=sayac[0];
    for(int i=1;i<10;i++)
    {
        sayac[i-1] = sayac[i];
        for(int j=0;j<9;j++)
        {
            int temp = enBuyuk;
            enBuyuk = sayac[j];
            sayac[j] = enBuyuk;
        }
        if (i == 9) { sayac[8] = enBuyuk; }
    }
    for (int i = 1; i < 10; i++)
    {
        if (sayac[i] > 0)
        {
            cout << i << " sayisindan " << sayac[i] << " tane var."<<endl;
        }
    }


}
