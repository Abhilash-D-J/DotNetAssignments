using System.Net;
using System.Xml.Linq;
using System;

namespace EmployeeLib
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
    public class Person
    {
        private string _name;
        private bool _gender;
        private Date _birth;
        private string _address;

        public Person()
        {
            birth = new Date();
        }

        public Person(string name, bool gender, int day, int month, int year, string address)
        {
            this.name = name;
            this.gender = gender;
            this.birth = new Date(day, month, year);
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
            Console.WriteLine("Name : " + this.name);
            Console.WriteLine("Gender : " + this.gender);
            Console.WriteLine("Birth date : " + birth.ToString());
            Console.WriteLine("Age : " + Date.getage(birth));
            Console.WriteLine("Address : " + this.address);
        }

    }
    public enum DepartmentType
    {
        IT = 1, SALES, MARKETING
    }
    public class Employee : Person
    {
        private int _id;
        private double _salary;
        private string _designation;
        private DepartmentType _dept;
        private static int count = 0;
        private bool _flag = true;

        public bool flag
        {
            get { return _flag; }
            set { _flag = value; }
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
            if (flag == true)
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
            Console.WriteLine("Salary : " + this.salary);
            Console.WriteLine("Designation : " + this.designation);
            Console.WriteLine("Department : " + this.dept.ToString());
        }
        public override string ToString()
        {
            return "id : " + id + ", name : " + name + ", gender : " + true + ", address : " + address
                + ", Salary : " + salary + ", designation : " + designation + ", department : " + dept.ToString();
        }
    }
}
