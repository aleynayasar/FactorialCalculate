using System;

namespace RecursiveMetot
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter the number you want to calculate the factorial : ");
            number = int.Parse(Console.ReadLine());

            int factorial = FactorialCalculate(number);
            Console.WriteLine("Factorial result : {0}",factorial);
            Console.ReadLine();

        }

        private static int FactorialCalculate(int number)
        {
            if (number <= 1)
                return 1;
            else
                return number * FactorialCalculate(number - 1);

        }
        
    }
}
