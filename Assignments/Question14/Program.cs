using EmployeeLib;

namespace Question14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Company company = new Company();
            do
            {
                Console.WriteLine("Enter");
                Console.WriteLine("1.Add Company\n2.Display Company\n3.Add Employee \n4.Remove Employee\n5.Find Employee\n6.Display All Employee");    
                Console.WriteLine("Enter Choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("thank you ");
                        break;

                    case 1:
                        company.accept();
                        break;

                    case 2:
                        company.print();
                        break;

                    case 3:
                        Employee employee = new Employee();
                        employee.accept();
                        company.addEmployee(employee);
                        break;

                    case 4:
                        Console.WriteLine("Enter id ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        company.removeEmployee(id);
                        break;

                    case 5:
                        Console.WriteLine("Enter id ");
                        int id1 = Convert.ToInt32(Console.ReadLine());
                        LinkedListNode<Employee> empList = company.FindEmployee(id1);
                        Console.WriteLine(empList.Value);
                        break;

                    case 6:
                        company.printEmployees();
                        break;

                    default:
                        Console.WriteLine("Enter Valid Choice ");
                        break;

                }

            } while (choice != 0);
        }
    }
}
