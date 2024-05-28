namespace Assi2Que4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.acceeptDetails();
            student.printDetails();
            Console.ReadLine();
        }
    }

    struct Student
    {
        private string _name;
        private bool _gender;
        private int _age;
        private int _std;
        private char _div;
        private double _marks;

        public Student(string name, bool gender, int age, int std, char div, double marks)
        {
            _name = name;
            _gender = gender;
            _age = age;
            _std = std;
            _div = div;
            _marks = marks;
        }

        public double marks
        {
            get { return _marks; }
            set { _marks = value; }
        }


        public char div
        {
            get { return _div; }
            set { _div = value; }
        }


        public int std
        {
            get { return _std; }
            set { _std = value; }
        }


        public int age
        {
            get { return _age; }
            set { _age = value; }
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

        public void acceeptDetails()
        {
            Console.WriteLine("Enter Student Details : ");
            Console.WriteLine("Enter Name :");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter Gender :");
            this.gender = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Enter Age :");
            this.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Std :");
            this.std = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Div :");
            this.div = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter Marks :");
            this.marks = Convert.ToInt32(Console.ReadLine());
        }

        public void printDetails()
        {
            Console.WriteLine("\nStudent Details are -----");
            Console.WriteLine("Name : "+this.name);
            Console.WriteLine("Gendr : "+this.gender);
            Console.WriteLine("Age : "+this.age);
            Console.WriteLine("Std : "+this.std);
            Console.WriteLine("Div : "+this.div);   
            Console.WriteLine("Marks : "+this.marks);
        }
    }
}
