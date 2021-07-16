#include <iostream>

using namespace std;

int randReturn()
{
	return rand() % 4 + 1;
}

class marketQueue
{
private:
	int start = 0;
	int finish = 0;
	int queue[100] = { 0 };
	int lastCustomer = 0;
public:
	void checkQueue()
	{
		if(finish==100)
		{
			finish = 0;
		}
		if(start==100)
		{
			start = 0;
		}
	}

	void addCustomer(int enterTime)
	{
		checkQueue();
		queue[finish] = enterTime;

		finish = finish + 1;
	}
	void outCustomer(int nextOut, int* nextOutCustomer, int passTime,int* maxWait,float *totalWait)
	{
		if (queue[nextOut] > 0)
		{
			*nextOutCustomer = passTime + randReturn();
		}
		*totalWait = *totalWait + (*nextOutCustomer - queue[nextOut]);
		if(*nextOutCustomer-queue[nextOut]>*maxWait)
		{
			*maxWait = *nextOutCustomer - queue[nextOut];
		}


	}


};

int main()
{
	int core;
	int endTime = 0;
	int passTime = 0;
	int willEnterTime = 0;
	int willOutTime = 0;
	int nextOut = 0;
	int nextOutCustomer = 0;
	int maxWait = 0;
	int maxCustomer = 0;
	int totalCustomer = 0;
	float totalWait = 0;
	float totalOutCustomer = 0;
	double avrWait = 0;
	int allCustomer = 0;

	marketQueue shoppingQueue;

	cout << "Sayi uretici cekirdegini giriniz." << endl;
	cin >> core;
	cout << "Simulasyonun suresini belirleyiniz." << endl;
	cin >> endTime;
	srand(core);
	willEnterTime = randReturn();

	bool isEmpty = true;
	cout << endl << "Simulasyon basliyor..." << endl;
	while(passTime<endTime)
	{
		if(passTime>0)
		{
			if(willEnterTime==passTime)
			{
				allCustomer++;
				cout << willEnterTime << ". dakikada Musteri#" << allCustomer << " geldi." << endl;
				totalCustomer++;
				if(totalCustomer>maxCustomer)
				{
					maxCustomer = totalCustomer;
				}
				if(nextOutCustomer==0)
				{
					nextOutCustomer = willEnterTime+randReturn();
					nextOut++;
				}
				shoppingQueue.addCustomer(willEnterTime);
				willEnterTime = willEnterTime + randReturn();
			}
			if (nextOutCustomer == passTime)
			{
				cout << nextOutCustomer << ". dakikada Musteri#" << nextOut << " gitti." << endl;
				totalCustomer--;
				totalOutCustomer++;
				nextOutCustomer = -1;
			}
			if (nextOutCustomer == -1)
			{
				shoppingQueue.outCustomer(nextOut, &nextOutCustomer,passTime,&maxWait,&totalWait);
				if(nextOutCustomer!=-1)
				{
					nextOut++;
				}
			}

		}

		passTime++;
	}
	cout << "Simulasyon bitti..." << endl << endl;
	cout << "Simulasyon sonuclari" << endl;
	avrWait = totalWait / totalOutCustomer;
	cout << "Sirada en cok bekleyen musteri toplamda " << maxWait << " dk sirada bekledi" << endl;
	cout << "Herhangi bir zamanda kuyrukta bulunan max kisi sayisi " << maxCustomer << endl;
	cout << "Kuyrukta oralama bekleme suresi " << avrWait << endl;


}
