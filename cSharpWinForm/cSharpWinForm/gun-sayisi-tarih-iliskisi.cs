using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpWinForm
{
	public class gun_sayisi_tarih_iliskisi
	{
		check_and_use checker = new check_and_use();


		//geri gidilecek tarihi hesaplar
		public void goBackInDate(int year, int month, int day, int backDay, ref int newYear, ref int newMonth, ref int newDay)
		{
			newYear = year;
			newMonth = month;
			newDay = day;
			if (backDay > day)
			{
				backDay -= day;
				newDay = 0;
				newMonth--;
			}
			if (newMonth < 1)
			{
				newMonth = 12;
				newYear--;
			}

			while (backDay > checker.daysOfMonth(newYear, newMonth - 1))
			{
				backDay -= checker.daysOfMonth(newYear, newMonth);
				newMonth--;
				if (newMonth < 1)
				{
					newMonth = 12;
					newYear--;
				}
			}
			if (newYear != year && newMonth != month)
			{
				newDay = checker.daysOfMonth(newYear, newMonth) - backDay;
			}
            else 
			{
                if (newDay == 0) 
				{
					newDay = checker.daysOfMonth(newYear, newMonth);
				}
				newDay -= backDay;
			}
			if (newDay == 0)
			{
				newMonth--;
				if (newMonth == 1)
				{
					newDay = checker.daysOfMonth(newYear - 1, 12);
				}
				else
				{
					newDay = checker.daysOfMonth(newYear, newMonth);
				}
			}

		}

		//ileri gidilecek tarihi hesaplar
		public void goForwardInDate(int year, int month, int day, int skipDay, ref int newYear, ref int newMonth, ref int newDay)
		{
			newYear = year;
			newMonth = month;
			newDay = day;

			if (skipDay > (checker.daysOfMonth(year, month) - day))
			{
				skipDay -= (checker.daysOfMonth(year, month) - day);
				newDay = 0;
				newMonth = newMonth + 1;
			}
			if (month > 12)
			{
				newMonth = 1;
			}

			while (skipDay >= checker.daysOfMonth(newYear, newMonth))
			{
				skipDay -= checker.daysOfMonth(newYear, newMonth);
				newMonth = newMonth + 1;
				if (newMonth > 12)
				{
					newMonth = 1;
					newYear = newYear + 1;
				}
			}

			if (skipDay == 0)
			{
				if (month == 1)
				{
					newDay = checker.daysOfMonth(year - 1, 12);
				}
				else
				{
					newDay = checker.daysOfMonth(year, month - 1);
				}
			}
			else
			{
                if (newDay != 0) 
				{
					newDay += skipDay;
				}
                else
				{
					newDay = skipDay;
				}
			}


		}
	}
}
