using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            int choice = 0;

            string input = "";
            string result = "";
            string choiceNumber = "";
            do
            {
                Console.WriteLine("\t\tWCF Assignment 1");
                Console.WriteLine("");
                Console.WriteLine("1. Prime number");
                Console.WriteLine("2. Sum of digits");
                Console.WriteLine("3. Reverse a string");
                Console.WriteLine("4. Print HTML tags");
                Console.WriteLine("5. Sort 5 numbers");
                Console.WriteLine("6. Exit");
                Console.WriteLine("");
                Console.Write("Enter your choice: \t\t");
                choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:

                        Console.WriteLine("");
                        Console.Write("Please enter a number: \t\t");
                        input = Console.ReadLine();
                        result = client.CheckPrimeNumber(input);
                        Console.WriteLine(result);

                        break;
                    case 2:
                        Console.Write("Please enter a digits: \t\t");
                        input = Console.ReadLine();
                        result = client.CalculateSumOfDigits(input);
                        Console.WriteLine(result);

                        break;
                    case 3:
                        Console.Write("Please enter a word or sentence: \t\t");
                        input = Console.ReadLine();
                        result = client.ReverseString(input);
                        Console.WriteLine(result);
                        break;
                    case 4:
                        Console.WriteLine("Please enter a Tag:");
                        Console.Write("Tag: ");
                        string inputTag = Console.ReadLine();
                        Console.WriteLine("Please enter Data:");
                        Console.Write("Data: ");
                        string inputData = Console.ReadLine();
                        result = client.PrintHTMLTag(inputTag, inputData);
                        Console.WriteLine(result);
                        break;
                    case 5:

                        Console.WriteLine("Please choose one of two sort types: 1. Ascending\t2. Descending");
                        choiceNumber = Console.ReadLine();
                        Console.WriteLine("Please enter 5 numbers: ");
                        input = Console.ReadLine();
                        result = client.SortNumbers(choiceNumber, input);
                        Console.WriteLine(result);
                        break;
                    default:
                        break;
                }

            } while (choice != 6);

            Console.ReadLine();
        }
    }
}
