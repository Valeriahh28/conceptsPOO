using System;
using System.Collections.Generic;
using System.Text;

namespace conceptsPOO
{
    public class Date
    {
        private int year;
        private int month;
        private int day;

        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = checkMonth(month);
            this.day = checkday(year, month, day);
        }

        private int checkday(int year, int month, int day)
        {

            if (month == 2 && day==29 && Isleapyear(year))
            {
                return day;
            }
            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (day >= 1 && day <= daysPerMonth[month])
            {
                return day;
            }
            throw new dayException("Día no valido");
        }

        private bool Isleapyear(int year)
        {

            return year % 400 ==0 || year % 4 == 0 && year % 100 != 0; 
            throw new NotImplementedException();
        }

        private int checkMonth(int month)
        {

            if (month >= 1 && month <= 12)
            {
                return month;
            }
            throw new  MonthException("Mes no valido");
        }

        public override string ToString()
        {
            return  $"{this.year}/{this.month:00}/{this.day:00}";
        }
    }
}
