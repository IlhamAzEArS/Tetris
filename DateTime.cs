using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Date
    {
        private int day, year, month;
        public Date()
        {
            day = 1;
            month = 1;
            year = 1990;
        }
       public  Date(int _day, int _month, int _year)
        {
            this.day = _day;
            this.month = _month;
            this.year = _year;


        }
        // Methods
        public void addDays(int days_count)
        {
            for (int i = 0; i < days_count; i++)
            {
                if (this.month == 4 || this.month == 6 || this.month == 9 || this.month == 11)
                {
                    if (this.day <= 30)
                    {
                        this.day += 1;

                    }
                    if (this.day == 30)
                    {
                        if (this.month < 12)
                        {
                            this.day = 1;
                            this.month += 1;
                        }
                    }

                }
                else
                {
                    if(this.day <= 31)
                    {
                        this.day += 1;
                    }
                    if (this.day == 31)
                    {
                        if (this.month < 12)
                        {
                            this.day = 1;
                            this.month += 1;
                        }
                    }

                }
                if (this.day == 30)
                {
                    if (this.month < 12)
                    {
                        this.day = 1;
                        this.month += 1;
                    }
                }
                if(this.month >=12)
                {
                    this.month = 1;
                    this.year += 1;
                }




            }
        }
        public bool isLeap(int year_)
        {

            
                if (DateTime.IsLeapYear(year_))
                {
                    Console.WriteLine("{0} is a leap year.", year_);
                    DateTime leapDay = new DateTime(year_, 2, 29);
                    DateTime nextYear = leapDay.AddYears(1);
                    Console.WriteLine("   One year from {0} is {1}.", leapDay.ToString("d"), nextYear.ToString("d"));
                return true;
                }
            return false;
            

        }//true if in year 366 days
        public int DaysINMonth(int @Year,int @Month)
        {
            return DateTime.DaysInMonth(@Year, @Month);
        }
        public void dayOfWeek(int @year,int @month,int @day)
        {
            DateTime dt = new DateTime(@year, @month, @day);
            Console.WriteLine(   dt.DayOfWeek); 
        }

        public override string ToString()
        {
            return $"{day}.{month}.{year}";
        }
    };
    class Program
    {
        static void Main(string[] args)
        {
            Date datatime = new Date(20,4,2019);

            datatime.addDays(367);
            Console.WriteLine(datatime);
            Console.WriteLine("===========================");
            Console.WriteLine(datatime.isLeap(2020));
            datatime.dayOfWeek(2019,4,15);
        }
    }
}
