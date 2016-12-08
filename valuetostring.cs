using System;
namespace TypeConversion
{
    class Program
    {
        static void Main(string[]args)
        {
            //value types
            int i = 20;
            double d = 59239.8428;
            bool b = true;
            float f = 1823.12f;

            /*convert value types to string*/
            Console.WriteLine(i.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine(f.ToString());


        }
    }
}
