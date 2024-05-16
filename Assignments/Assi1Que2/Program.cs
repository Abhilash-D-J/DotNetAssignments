namespace Assi1Que2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st Number : ");
            String ivalue = Console.ReadLine();
            int i = Convert.ToInt32(ivalue);

            Console.WriteLine("Enter 2st Number : ");
            String jvalue = Console.ReadLine();
            int j = Convert.ToInt32(jvalue);

            Console.WriteLine("1.Addition \n2.Substraction \n3.Multiplication \n4.Division");

            Console.WriteLine("Enter Choice : ");
            String kvalue = Console.ReadLine(); 
            int Choice = Convert.ToInt32(kvalue);
            
            
            int result;

            switch (Choice)
            {

                    case 1:
                     result = i + j;
                    Console.WriteLine(result);
                    break;

                    case 2:
                     result = i - j;
                    Console.WriteLine(result);
                    break;

                    case 3:
                    result = i * j;
                    Console.WriteLine(result);
                    break;

                    case 4:
                    result = i / j;
                    Console.WriteLine(result);
                    break;

                    default :
                    Console.WriteLine("Enter valid CHoice !! ");
                    break;
            }
        }
    }
}
