using System;
namespace ArrayApplication
{
    class ParamArray
    {
        public int AddElements(params int[] arr)
        {
            int sum =0;
            foreach (int i in arr)
            {
                sum += 1;

            }
            return sum;
        }
    }
}
