using Assi3Que8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi4Que12
{
    internal class Company
    {
		private string _name;
		private string  _address;
		private LinkedList<Employee> _empList;
		private double _salaryExpense;

		public Company()
		{
			empList = new LinkedList<Employee>();
		}

        public Company(string name, string address, LinkedList<Employee> empList, double salaryExpense)
        {
            _name = name;
            _address = address;
            _empList = empList;
            _salaryExpense = salaryExpense;
        }

        public double salaryExpense
		{
			get { return _salaryExpense; }
			set { _salaryExpense = value; }
		}


		public LinkedList<Employee> empList
		{
			get { return _empList; }
			set { _empList = value; }
		}


		public string  address
		{
			get { return _address; }
			set { _address = value; }
		}


		public string name
		{
			get { return _name; }
			set { _name = value; }
		}

		public void accept()
		{
			Console.WriteLine("Enter Company Name : ");
			this.name = Console.ReadLine();
			Console.WriteLine("Enter Company Address : ");
			this.address = Console.ReadLine();
			salaryExpense = calculateSalaryExpense();
		}

		public void print()
		{
			Console.WriteLine("Company name : "+name);
			Console.WriteLine("Company Address : " + address);
			Console.WriteLine("Number of Employees : " + empList.Count);
			Console.WriteLine("Salary Expense : " + salaryExpense);
		}

		public  double calculateSalaryExpense()
		{
			double totalsalary=0;
			foreach(Employee e in _empList)
			{
				totalsalary += e.salary;
			}
			return totalsalary;
		}

		public void addEmployee(Employee e)
		{
			empList.AddFirst(e);
		}

		public void removeEmployee(int id)
		{

		}

		public LinkedListNode<Employee>? FindEmployee(int id)
		{
          foreach(Employee e in empList)
			{
				if(e.id == id)
				{
				 return new LinkedListNode<Employee> (e);
				}
			}
				return null;
		}

        public override string ToString()
        {
            return "Company Name : "+name+", Company address : "+address+", SalaryExpense : "+salaryExpense;
        }

		public void printEmployees()
		{
			foreach(Employee e in empList)
			{
				Console.WriteLine (e);
			}
		}
    }
}
