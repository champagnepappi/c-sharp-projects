using System;
namespace Loops
{
    class Program
    {
        static void Main(string[]args)
        {
            /*local variable definition*/
            int a =10;

            while(a<20)
            {
                Console.WriteLine("value of a :{0}", a);
                a++;
                if(a > 15)
                {
                    break;
                }
            }
            Console.ReadLine();
        }

    }
}
