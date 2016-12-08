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
    }
}
