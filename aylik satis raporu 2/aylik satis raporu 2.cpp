#include <iostream>

using namespace std;


int date = 0;
int satis = 0;
int temsilciID;
int totalSold = 0;
class temsilci
{
public:
	int id = 0;
	int totalSold = 0;
	int soldingDay = 0;
	int topSold = 0;
	int totalDay = 0;
	int ortDay = 0;
	temsilci() {
		
	}
	void dailyCheck()
	{
		totalSold += soldingDay;
		totalDay++;
		ortDay = totalSold / totalDay;
		cout << id << " numarali temsilcinin bugun yapmis oldugu satis =>  " << soldingDay << endl;
		cout << id << " numarali temsilcinin bugune kadar yapmis oldugu ortalama satis =>  " << ortDay << endl;
		if(soldingDay>topSold)
		{
			topSold = soldingDay;
		}
	}
};


int main()
{
	temsilci hamdi;
	hamdi.id = 101;

	temsilci ahmet;
	ahmet.id = 105;

	temsilci can;
	can.id = 110;

	temsilci* temsilciler[10];


	while (temsilciID != -1)
	{
		if (temsilciID == -1) {
			break;
		}
		cout << "temsilci numarasi giriniz" << endl;
		cin >> temsilciID;
		cout << "temsilcinin gunluk satis miktarni giriniz" << endl;
		cin >> satis;
		totalSold += satis;
		if(temsilciID==hamdi.id)
		{
			hamdi.soldingDay = satis;
			hamdi.dailyCheck();
		}
		if(temsilciID==ahmet.id)
		{
			ahmet.soldingDay = satis;
			ahmet.dailyCheck();
		}
		if(temsilciID==can.id)
		{
			can.soldingDay = satis;
			can.dailyCheck();
		}
		date++;
	}
	int topSolding;
	int topSolder;

	int lessAvrSolder;
	int lessAvrSolding;
	//gunluk ortalama en az satis 
	lessAvrSolder = hamdi.id;
	lessAvrSolding = hamdi.ortDay;
	if (ahmet.ortDay < lessAvrSolding)
	{
		lessAvrSolding = ahmet.ortDay;
		lessAvrSolder = ahmet.id;
	}
	if (can.ortDay < lessAvrSolding)
	{
		lessAvrSolding = can.ortDay;
		lessAvrSolder = can.id;
	}
	
	//ay boyunca en cok satis
	topSolding = hamdi.totalSold;
	topSolder = hamdi.id;
	if ( ahmet.totalSold > topSolding)
	{
		topSolding = ahmet.totalSold;
		topSolder = ahmet.id;
	}if ( can.totalSold > topSolding) {
		topSolding = can.totalSold;
		topSolder = can.id;
	}
	//gunluk ortalama en cok satis
	int topAvrTsc;
	int topAvrAmount;
	topAvrTsc = hamdi.id;
	topAvrAmount = hamdi.ortDay;
	if (ahmet.ortDay>topAvrAmount) 
	{
		topAvrAmount = ahmet.ortDay;
		topAvrTsc = ahmet.id;
	}
	if(can.ortDay> topAvrAmount)
	{
		topAvrAmount = can.ortDay;
		topAvrTsc = can.id;
	}

	//bir gunde yapilan en cok satis
	int allTopTsc;
	int allTopAmount;
	allTopTsc = hamdi.id;
	allTopAmount = hamdi.topSold;
	if (ahmet.topSold > allTopAmount)
	{
		allTopAmount = ahmet.topSold;
		allTopTsc = ahmet.id;
	}
	if (can.topSold > allTopAmount)
	{
		allTopAmount = can.topSold;
		allTopTsc = can.id;
	}

	cout << "bu ay yapilan toplam satis =>  " << totalSold << endl;
	cout << "bu ay temsilci basina dusen ortalama satis tutari =>  " << totalSold / 3<<endl<<endl;
	cout << "bu ay en cok satis yapan temsilci =>  "<< topSolder  <<endl;
	cout << "bu ay en cok satis yapan temsilcinin sattigi toplam tuar =>  " << topSolding << endl << endl;
	cout << "bu ay en cok ortalama gunluk satis yapan temsilci =>  " << topAvrTsc << endl;
	cout << "bu ay en cok ortalama gunluk satis yapan temsilcinin yaptigi gunluk satis =>  " << topAvrAmount << endl<<endl;
	cout << "bu ay en az gunluk satis yapan temsilci =>  " << lessAvrSolder << endl;
	cout << "bu ay en az gunluk satis yapan temsilcinin yaptigi gunluk satis =>  " << lessAvrSolding << endl << endl;
	cout << "bu ay en icinde cok gunluk satis yapan temsilci =>  " << allTopTsc << endl;
	cout << "bu ay en icinde cok gunluk satis yapan temsilcinin yaptigi gunluk satis =>  " << allTopAmount << endl << endl;


}