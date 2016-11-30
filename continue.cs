using System;
namespace Loops
{
    class Program
    {
        static void Main(string[]args)
        {
            int a= 10;
            do
            {
                if(a==15)
                {
                    //skip iteration
                    a = a+1;
                    continue;
                }
                Console.WriteLine("Value of a: {0}", a);
                a++;
            }while(a<20);
            
            Console.ReadLine();

        }
    }
}
