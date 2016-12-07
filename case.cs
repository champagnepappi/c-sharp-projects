using System;
namespace DecisionMaking
{
    class Program
    {
        static void Main(string[]args)
        {
            /* local variable definition*/
             char grade = 'B';

             switch(grade)
             {
                 case 'A':
                     Console.WriteLine("Excellent!");
                     break;
                 case 'B':
                     Console.WriteLine("Average Performance");
                     break;
                 case 'C':
                     Console.WriteLine("Well Done");
                     break;
                 case 'D':
                     Console.WriteLine("Ypu passed");
                     break;
                 case 'E':
                     Console.WriteLine("Better try again");
                     break;
                 default:
                     Console.WriteLine("Invalid grade");
                     break;
             }
        }
    }
}
