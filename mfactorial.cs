using System;
namespace Factorial
{
    class Program
    {
        public int factorial(int num)
        {
            int result;

            if(num==1)
            {
                return 1;
            }
            else
            {
                result = factorial(num-1)*num;
                return result;
            }
        }
        static void Main(string[]args)
        {
            int f,r;
            Program n = new Program();
            Console.WriteLine("Enter number to get factorial: ");
            f = Convert.ToInt32(Console.ReadLine());
            r = n.factorial(f);
            Console.WriteLine("Factorial of {0} is {1}",f,r);
        }
    }
}
