using System;
using System.Collections.Generic;
using System.Text;

namespace obwee
{
    class YearMonthDay
    {
        private int year;
        private int month;
        private int day;

        public YearMonthDay(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public YearMonthDay(string stroka)
        {
            string[] mas = stroka.Split('.');
            this.day = Convert.ToInt32(mas[0]);
            this.month = Convert.ToInt32(mas[1]);
            this.year = Convert.ToInt32(mas[2]);
        }

        public YearMonthDay(YearMonthDay other)
        {
            this.year = other.year;
            this.day = other.day;
            this.month = other.month;
        }

        public YearMonthDay addDayToData(int day)
        {
            for (int i = 0; i < day; i++)
            {
                this.day++;
                if (this.day == 31)
                {
                    this.day = 1;
                    this.month++;
                    if (this.month == 13)
                    {
                        this.month = 1;
                        this.year++;
                    }
                }
            }
            return new YearMonthDay(this.day, this.month, this.year);
        }

        public YearMonthDay subFromData(int days)
        {
            for (int i = 0; i < days; i++)
            {
                this.day--;
                if (this.day == 0)
                {
                    this.day = 30;
                    this.month--;
                    if (this.month == 0)
                    {
                        this.month = 12;
                        this.year--;
                    }
                }
            }
            return new YearMonthDay(this.day, this.month, this.year);
        }

        public void dateComparison(YearMonthDay other)
        {
            DateTime dateofthisclass = new DateTime(this.year, this.month, this.day);
            DateTime dateofanotherclass = new DateTime(other.year, other.month, other.day);
            if (dateofthisclass > dateofanotherclass)
                Console.WriteLine(dateofthisclass + " является больше " + dateofanotherclass);
            else
                Console.WriteLine(dateofanotherclass + " является больше " + dateofthisclass);
        }

        public void subtractionDaysBetweenData(YearMonthDay other)
        {
            Console.WriteLine("Вычитание одной даты из другой:");
            DateTime dateofthisclass = new DateTime(this.year, this.month, this.day);
            DateTime dateofanotherclass = new DateTime(other.year, other.month, other.day);
            if (dateofthisclass > dateofanotherclass)
                Console.WriteLine(dateofthisclass.Subtract(dateofanotherclass));
            else
                Console.WriteLine(dateofanotherclass.Subtract(dateofthisclass));
        }
        public string getData() => $"{this.year}.{this.month}.{this.day}";
    }
}
