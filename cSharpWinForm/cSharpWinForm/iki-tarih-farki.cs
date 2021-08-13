using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpWinForm
{
    class iki_tarih_farki
    {
		check_and_use checker = new check_and_use();
		public void dateDifference(int year1, int month1, int day1, int year2, int month2, int day2, ref int result)
		{
			int totalDay = 0;

			int lowYear;
			int lowMonth;
			int lowDay;
			int bigYear;
			int bigMonth;
			int bigDay;
			if (year1 < year2)
			{
				lowYear = year1;
				lowMonth = month1;
				lowDay = day1;
				bigYear = year2;
				bigMonth = month2;
				bigDay = day2;
			}
			else
			{
				if (year1 > year2)
				{
					lowYear = year2;
					lowMonth = month2;
					lowDay = day2;
					bigYear = year1;
					bigMonth = month1;
					bigDay = day1;
				}
				else
				{
					if (month1 < month2)
					{
						lowYear = year1;
						lowMonth = month1;
						lowDay = day1;
						bigYear = year2;
						bigMonth = month2;
						bigDay = day2;
					}
					else
					{
						if (month1 > month2)
						{
							lowYear = year2;
							lowMonth = month2;
							lowDay = day2;
							bigYear = year1;
							bigMonth = month1;
							bigDay = day1;
						}
						else
						{
							if (day1 < day2)
							{
								lowYear = year1;
								lowMonth = month1;
								lowDay = day1;
								bigYear = year2;
								bigMonth = month2;
								bigDay = day2;
							}
							else
							{
								lowYear = year2;
								lowMonth = month2;
								lowDay = day2;
								bigYear = year1;
								bigMonth = month1;
								bigDay = day1;
							}
						}
					}
				}
			}

			//kagitta yazan kisim1
			totalDay = checker.daysOfMonth(lowYear, lowMonth) - lowDay;
			lowMonth++;
			if (bigYear > lowYear)
			{
				for (; lowMonth < 13; lowMonth++)
				{
					totalDay += checker.daysOfMonth(lowYear, lowMonth);
				}
			}
			if (lowMonth > 12)
			{
				lowMonth = 1;
			}
			lowYear++;//kagitta yazan kisim3
			while (lowYear < bigYear)
			{
				while (lowMonth < 13)
				{
					totalDay += checker.daysOfMonth(lowYear, lowMonth);
					lowMonth++;
				}
				lowMonth = 1;
				lowYear++;
			}

			//kagitta yazan kisim2
			while (lowMonth < bigMonth)
			{
				totalDay += checker.daysOfMonth(lowYear, lowMonth);
				lowMonth++;
			}

			totalDay += bigDay;
			result = totalDay;

			//kagitta not aldigim birinci-ikinci-ucuncu kisimlari sirasiyla aktar.

		}
	}
}
