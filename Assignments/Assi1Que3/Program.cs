namespace Assi1Que3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            int Choice;
            do
            {
                Console.WriteLine("1.Addition \n2.Substraction \n3.Multiplication \n4.Division");

                Console.WriteLine("Enter Choice : ");
                String kvalue = Console.ReadLine();
                Choice = Convert.ToInt32(kvalue);

                Console.WriteLine("Enter 1st Number : ");
                String ivalue = Console.ReadLine();
                int i = Convert.ToInt32(ivalue);

                Console.WriteLine("Enter 2st Number : ");
                String jvalue = Console.ReadLine();
                int j = Convert.ToInt32(jvalue);

                int result;

                switch (Choice)
                {

                    case 1:
                        result = i + j;
                        Console.WriteLine("Result : "+result);
                        break;

                    case 2:
                        result = i - j;
                        Console.WriteLine("Result : " + result);
                        break;

                    case 3:
                        result = i * j;
                        Console.WriteLine("Result : " + result);
                        break;

                    case 4:
                        result = i / j;
                        Console.WriteLine("Result : " + result);
                        break;

                    default:
                        Console.WriteLine("Enter valid CHoice !! ");
                        break;
                }

            } while (Choice != 0);
        }
    }
}
