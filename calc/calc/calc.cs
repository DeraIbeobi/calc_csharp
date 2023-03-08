using System;
namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Enter numbers separated by commas:");
        string input = Console.ReadLine();
        char[] divide = { ',', ' ' };
        string[] segments = input.Split(divide);
        int nSum = 0;
        foreach (string s in segments) {
                    int num = Int32.Parse(s);
                    Console.WriteLine("number = {0}", num);
                    nSum += num;
                
            
        }
        Console.WriteLine("Total = {0}", nSum);
        System.Console.WriteLine("Press any key to exit");
        Console.ReadKey();
        }

    

            /*
           System.Console.WriteLine("Seperated strings");
           string authors = "Chidera, Ibeobi, Dera, Dde, Praise";
           string[] authorsList = authors.Split(",");
           foreach (string author in authorsList)
           System.Console.WriteLine(author);*/
        }
    }
