using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Assi3Que8
{
	public enum DepartmentType 
	{
		IT =1,SALES,MARKETING
	}
    public class Employee : Person
    {
		private int _id;
		private double _salary;
		private string _designation;
		private DepartmentType _dept;
		private static int count =0;
		private bool _flag = true;

		public bool flag
		{
			get { return _flag ; }
			set { _flag  = value; }
		}


		public Employee()
		{
			count++;
			_id = count;
		}

        public Employee(double salary, string designation, DepartmentType dept) : base() 
		{
			count++;
			_id = count;
            _salary = salary;
            _designation = designation;
            _dept = dept;
        }

        public DepartmentType dept
		{
			get { return _dept; }
			set { _dept = value; }
		}


		public string designation
		{
			get { return _designation; }
			set { _designation = value; }
		}


		public double salary
		{
			get { return _salary; }
			set { _salary = value; }
		}


		public int id
		{
			get { return _id; }
		}

		public void accept()
		{
			base.accept();
			if (flag==true)
			{
				Console.WriteLine("Enter Salary :");
                this.salary = Convert.ToDouble(Console.ReadLine());
            }
			if (this.designation == null)
			{
				Console.WriteLine("Enter Designation : ");
				this.designation = Console.ReadLine();
			}
			Console.WriteLine("Enter \n1.IT\n2.SALES\n3.MARKETING\n : ");
			int no = Convert.ToInt32(Console.ReadLine());
			if (no == 1)
				this.dept = DepartmentType.IT;
			else if (no == 2)
				this.dept = DepartmentType.SALES;
			else if (no == 3)
				this.dept = DepartmentType.MARKETING;
			else
				Console.WriteLine("Enter Valid Choice");
		}

		public void printDetails()
		{
			base.printDetails();
			Console.WriteLine("Id : " + this.id);
			Console.WriteLine("Salary : "+this.salary);
			Console.WriteLine("Designation : "+this.designation);
			Console.WriteLine("Department : "+this.dept.ToString());
		}

        public override string ToString()
        {
            return "id : "+id+", name : "+name+", gender : "+true+", address : "+address
				+", Salary : "+salary+", designation : "+designation+", department : "+dept.ToString();
        }
    }
}
