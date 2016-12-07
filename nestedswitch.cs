using System;
namespace DecisionMaking
{
    class Program
    {
        static void Main(string[]args)
        {
            int a = 100;
            int b = 200;

            switch(a)
            {
                case 100:
                    Console.WriteLine("This is part of outer switch");
                    switch(b)
                    {
                        case 200:
                            Console.WriteLine("This is part of inner switch");
                            break;
                    }
                    break;
            }
        }
    }
}
