using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assi3Que8;


namespace Assi3Que9
{
    public class Manager : Employee
    {
		private double _bonus;

		public Manager() 
		{
			this.designation = "Manager";
		}

        public Manager(double bonus):base()
        {
            this.designation = "Manager";
			this.bonus = bonus;
        }

        public double bonus
		{
			get { return _bonus; }
			set { _bonus = value; }
		}

		public void accept()
		{
			base.accept();
			Console.WriteLine("Enter Bonus : ");
			this.bonus = Convert.ToDouble(Console.ReadLine());
		}

		public void printDetails()
		{
			base.printDetails();
			Console.WriteLine("Bonus : "+this.bonus);
		}

        public override string ToString()
        {
            return base.ToString()+", Bonus : "+this.bonus;
        }

    }
}
