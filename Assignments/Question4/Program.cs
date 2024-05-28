using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace Assi2Que1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date d1 = new Date();
            Date d2 = new Date();
            d1.accept();
            d2.accept();
            if(d1.isValid()&& d2.isValid()) {
                Console.WriteLine("-------dates Are -----");
                d1.print();
                d2.print();
                Console.WriteLine("Date Difference : " + Date.dateDiff(d1, d2));
                int diff = d1 - d2;
                Console.WriteLine("Date Difference with Operator Overloading : " + diff);
            }
            else
            {
                Console.WriteLine("dates Are not valid !! Enter valid dates ");
            }
           
        }
    }

}
