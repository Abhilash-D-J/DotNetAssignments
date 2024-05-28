using Assi3Que8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi3Que10
{
    internal class Supervisor : Employee
    {
		private int _subordinates;
        
		public Supervisor() : base()
		{
			designation = "Supervisor";
		}
        public Supervisor(int subordinates) : base()
        {
            designation = "Supervisor";
			this._subordinates = subordinates;
        }
        public int subordinates
		{
			get { return _subordinates; }
			set { _subordinates = value; }
		}
		public void accept()
		{
			base.accept();
			Console.WriteLine("Enter Number of Subordinates : ");
			this.subordinates = Convert.ToInt32(Console.ReadLine());
		}

		public void printDetails()
		{
			base.printDetails();
			Console.WriteLine("No of Subordinates : "+this.subordinates);
		}

        public override string ToString()
        {
            return base.ToString()+", Subordinates ="+subordinates;
        }
    }
}
