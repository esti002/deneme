#include <iostream>
#include <fstream>
#include <cstdlib>

using namespace std;

bool sayiVarMi(int sayi,int* dizi)
{
    int isUsed=0;
    int usedNum;
    for(int i=0;i<6;i++)
    {
        usedNum = *(dizi + i);
        if(sayi== usedNum)
        {
            isUsed++;
        }
    }
    if (isUsed > 0)
    {
        return true;
    }
    else { return false; }
}
 bool rakamMi(int sayi)
 {
    if(sayi>-1&&sayi<10)
    {
        return true;
    }else
    {
        return false;
    }
 }

int main()
{
    int weekNum=1; int dayNum=1; int ata=-1;
    int gunler[6];
    int* dizi;
    dizi = &gunler[0];
    remove("new document.txt");
    fstream kayit;
    kayit.open("new document.txt", std::ios::in | ios::out | ios::app);
    for(int i=0;i<8;i++)
    {
        gunler[0] = -1;
        gunler[1] = -1;
        gunler[2] = -1;
        gunler[3] = -1;
        gunler[4] = -1;
        gunler[5] = -1;
        for (int j = 0; j < 6; j++) {
            cout << "Buhaftada girmedigin bir rakam gir." << endl << "!!!DIKKAT!!! ========= programdan cikis yapmak icin 0 giriniz." << endl;
            cin >> ata;
            if (ata == 0) 
            {
                kayit << 0 << endl;
                exit(0);
            }
            if (rakamMi(ata) == true)
            {

                if (sayiVarMi(ata, dizi) == false)
                {
                    gunler[j] = ata;
                    kayit << ata << endl;
                    cout << "Deger kaydedildi." << endl << endl;
                    dayNum++;
                    if (dayNum > 6)
                    {
                        weekNum++;
                        dayNum = 1;
                        kayit << endl;
                    }
                }
                else
                {
                    cout << "BU DEGER ZATEN GIRILMIS-------!!!!!!!" << endl << endl;
                    j--;
                }
            }
            else
            {
                cout << "!!!!!!!-------GIRDIGIN DEGER BIR RAKAM DEGIL-------!!!!!!!" << endl << endl;
                j--;
            }
        }
    }
    kayit << 0 << endl;
    kayit.close();
}
