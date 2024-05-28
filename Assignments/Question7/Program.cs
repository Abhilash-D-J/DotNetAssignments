namespace Assi2Que5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Student[] arr;
           arr = createArray();
            acceptInfo(arr);
            printInfo(arr);
            reverseArray(arr);
            printInfo(arr);
            Console.ReadLine();
         }

        public static Student[] createArray()
        {
            Console.WriteLine("Enter Size of Array : ");
            int count = Convert.ToInt32(Console.ReadLine());
            return new Student[count];
        }

        public static void acceptInfo(Student[] arr)
        {
           for (int i = 0;i<arr.Length;i++)
            {
                arr[i].acceeptDetails();
            }
        }

        public static void printInfo(Student[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].printDetails();
            }
        }

        public static void reverseArray(Student[] arr ) 
        {
            Console.WriteLine("\nReverse Array ------");
            for (int i = 0,  j= arr.Length-1; i < arr.Length && j>0; i++,j--) 
            {
              if(j>i)
                {
                    Student s;
                    s = arr[i];
                    arr[i] = arr[j];
                    arr[j] = s;
                }

            }
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
            name = Console.ReadLine();
            Console.WriteLine("Enter Gender :");
            gender = Convert.ToBoolean(Console.ReadLine());
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
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Gendr : " + gender);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Std : " + std);
            Console.WriteLine("Div : " + div);
            Console.WriteLine("Marks : " + marks);
        }
    }
}
