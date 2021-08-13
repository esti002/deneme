using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpWinForm
{
    class check_and_use
    {
		//girilen tarihleri kontrol etmek ve aylar ve yillardaki gun sayisini hesaplayan fonksiyonlar...

		//subat ayindaki gun sayisinin 28 mi 29 mu oldugunu heasplar.
		int daysOfFeb(int year)
		{
			if (year % 4 == 0)
			{
				if (year % 100 == 0)
				{
					if (year % 400 == 0)
					{
						if (year % 4000 == 0)
						{
							return 28;
						}
						else
						{
							return 29;
						}
					}
					else
					{
						return 28;
					}
				}
				else
				{
					return 29;
				}
			}
			else
			{
				return 28;
			}
		}

		//yil icerisindeki aylarda kac gun oldugunu hesaplar.
		public int daysOfMonth(int year, int month)
		{
			switch (month)
			{
				case 1:
				case 3:
				case 5:
				case 7:
				case 8:
				case 10:
				case 12:
					return 31;
					break;
				case 4:
				case 6:
				case 9:
				case 11:
					return 30;
					break;
				case 2:
					return daysOfFeb(year);

			}
			return 30;
		}

		//girilen tarihin gecerli bir tarih olup olmadigini kontrol eder.
		bool dateVerify(int year, int month, int day)
		{
			if (year < 0)
			{
				return false;
			}
			if (month < 1 && month > 12)
			{
				return false;
			}
			if (day < 1)
			{
				return false;
			}
			int tmp = -1;
			tmp = daysOfMonth(year, month);
			if (tmp != -1)
			{
				if (day > tmp)
				{
					return false;
				}
			}
			else
			{
				return false;
			}
			return true;
		}
	}
}
