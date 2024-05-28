using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi2Que1
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

        public void print()
        {
            Console.WriteLine("date : " + day + "/" + month + "/" + year);
        }

        public bool isValid()
        {
            try
            {
                DateTime d = new DateTime(year, month, day);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public static int dateDiff(Date d1, Date d2)
        {
            if (d1.year > d2.year)
            {
                return d1.year - d2.year;
            }
            else if (d1.year < d2.year)
            {
                return d2.year - d1.year;
            }
            else
            {
                return 0;
            }

        }

        public static int operator -(Date d1, Date d2)
        {
            if (d1.year > d2.year)
            {
                return d1.year - d2.year;
            }
            else if (d1.year < d2.year)
            {
                return d2.year - d1.year;
            }
            else
            {
                return 0;
            }
        }
    }
}
