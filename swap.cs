using System;
namespace CalculatorApplication
{
    class NumberManipulator
    {
        public void swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp; //put temp into y

        }
        static void Main(string[]args)
        {
            NumberManipulator n = new NumberManipulator();
                /* local variable declaration*/
                int a = 100;
            int b = 200;

            Console.WriteLine("Before swap, value of a: {0}", a);
            Console.WriteLine("Before swap, value of b: {0}", b);

            /*call function to swap the values*/
            n.swap(ref a, ref b);
            Console.WriteLine("After swap, value of a: {0}", a);
            Console.WriteLine("After swap, value of b: {0}", b);
            Console.ReadLine();
        }
    }
}
