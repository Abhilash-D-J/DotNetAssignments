using Assi3Que8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi3Que11
{
    internal class WageEmp : Employee
    {
		private int _hours;
		private int _rate;

		public WageEmp() : base()
		{
			flag = false;
			this.designation = "Wage";
		}

        public WageEmp(int hrs,int rate) : base()
        {
			flag = false;
			this._hours = hrs;
			this._rate = rate;
			this.designation = "Wage";
        }
        public int rate
		{
			get { return _rate; }
			set { _rate = value; }
		}

		public int hours
		{
			get { return _hours; }
			set { _hours = value; }
		}

		public void accept()
		{
			base.accept();
			Console.WriteLine("Enter No of Hours : ");
			this.hours = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter Rate : ");
			this.rate = Convert.ToInt32(Console.ReadLine());
			this.salary = this.hours*this.rate;
		}

		public void printDetails()
		{
			base .printDetails();
		}

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
