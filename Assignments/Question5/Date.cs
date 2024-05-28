using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi3Que7
{
    public class Date
    {
        private int _day;
        private int _month;
        private int _year;

        public Date()
        {

        }

        public Date(int day, int month, int year)
        {
            _day = day;
            _month = month;
            _year = year;
        }

        public int year
        {
            get { return _year; }
            set { _year = value; }
        }


        public int month
        {
            get { return _month; }
            set { _month = value; }
        }


        public int day
        {
            get { return _day; }
            set { _day = value; }
        }

        public override string ToString()
        {
            return day + "/" + month + "/" + year;
        }

        public void accept()
        {
            Console.WriteLine("Enter day : ");
            this.day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter month : ");
            this.month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter year : ");
            this.year = Convert.ToInt32(Console.ReadLine());
        }

        public static int getage(Date d1)
        {
            DateTime d2 = DateTime.Now;
            if (d1.year > d2.Year)
            {
                return d1.year - d2.Year;
            }
            else if (d1.year < d2.Year)
            {
                return d2.Year - d1.year;
            }
            else
            {
                return 0;
            }

        }

    }
}
