using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi3Que7
{
    internal class Person
    {
		private string _name;
		private bool _gender;
		private Date _birth;
		private string _address;

		public Person() { 
		birth = new Date();
		}

		public Person(string name,bool gender,int day,int month,int year,string address)
		{
			this.name = name;
			this.gender = gender;
			this.birth = new Date(day,month,year);
			this.address = address;
		}

		public string address
		{
			get { return _address; }
			set { _address = value; }
		}


		public Date birth
		{
			get { return _birth; }
			set { _birth = value; }
		}



		public bool gender
		{
			get { return _gender; }
			set { _gender = value; }
		}


		public string name
		{
			get { return _name; }
			set { _name = value; }
		}

		public void accept()
		{
			Console.WriteLine("Enter name : ");
			this.name = Console.ReadLine();
			Console.WriteLine("Enter Gender : ");
			this.gender = Convert.ToBoolean(Console.ReadLine());	
			Console.WriteLine("Enter BirthDate : ");
			this.birth.accept();
			Console.WriteLine("Enter address : ");
			this.address = Console.ReadLine();
		}

		public void printDetails()
		{
			Console.WriteLine("\n-----Details Area-----");
			Console.WriteLine("Name : "+this.name);
			Console.WriteLine("Gender : "+this.gender);
			Console.WriteLine("Birth date : "+birth.ToString());
			Console.WriteLine("Age : " + Date.getage(birth));
			Console.WriteLine("Address : "+this.address);
		}

	}
}
