using System;
namespace CalculatorApplication
{
    class NumberManipulator
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
    }
}
