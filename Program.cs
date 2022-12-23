using System;


namespace prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool nisPrime = true;
            Console.WriteLine("please enter n1");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter n2");
            int n2 =int.Parse(Console.ReadLine());

            for(int x = n1; x <= n2; x++)
			{
                for(int y = 2; y <= 9; y++)
				{
                    if(x != y && x % y == 0)

                    {
                        nisPrime = false;
                        break;
                    }
                }
                if(nisPrime && x > 1)

                {
                    Console.WriteLine("\t " + x );
                }
                nisPrime = true;
            }
            Console.ReadKey();

        }
    }
}
