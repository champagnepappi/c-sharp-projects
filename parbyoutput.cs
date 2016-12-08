using System;
namespace CalculatorApp
{
    class NumberManipulator
    {
        public void getValues(out int x,out int y)
        {
            Console.WriteLine("Enter the first value: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second value: ");
            y = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[]args)
        {
            NumberManipulator n = new NumberManipulator();
            int a, b;

            //call function to get the values
            n.getValues(out a, out b);
            Console.WriteLine("After Method Call, value of a: {0}", a);
            Console.WriteLine("After Method Call, value of b: {0}", b);
            Console.ReadLine();

        }
    }
}
