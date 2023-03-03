using System;
namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1,num2,num3,num4,total;
            Console.WriteLine("Enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            num4 = Convert.ToInt32(Console.ReadLine());

            total = num1 + num2 + num3 + num4;
            Console.WriteLine("{0} + {1} + {2} + {3} = {4}", num1,num2,num3,num4,total);
        }
    }
}