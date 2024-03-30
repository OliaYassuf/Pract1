using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It's easy to win forgiveness for being wrong;\nbeing right is what gets you into real trouble.\nBjarne Stroustrup");
            //Користувач вводить з клавіатури п'ять чисел. Необхідно знайти суму чисел,
            //максимум і мінімум з п'яти чисел, добуток чисел. Результат обчислень вивести на екран.

            //double[] numbers = new double[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("Enter the number: ");
            //    numbers[i] = double.Parse(Console.ReadLine());
            //}

            //double sum = 0;
            //foreach (double number in numbers)
            //{
            //    sum += number;
            //}

            //double max = numbers[0];
            //double min = numbers[0];
            //for (int i = 1; i < 5; i++)
            //{
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }
            //    if (numbers[i] < min)
            //    {
            //        min = numbers[i];
            //    }
            //}

            //double productNumbers = 1;
            //foreach (double number in numbers)
            //{
            //    productNumbers *= number;
            //}

            //Console.WriteLine("Sum of numbers: " + sum);
            //Console.WriteLine("Maximum: " + max);
            //Console.WriteLine("Minimum: " + min);
            //Console.WriteLine("Product of numbers: " + productNumbers);

            ////-----

            //Console.Write("Enter a six-digit number: ");
            //int num = int.Parse(Console.ReadLine());

            //int reversedNum = 0;

            //while (num > 0)
            //{
            //    int remainder = num % 10;
            //    reversedNum = (reversedNum * 10) + remainder;
            //    num /= 10;
            //}

            //Console.WriteLine("Result: " + reversedNum);

            ////------

            //Console.Write("Enter the start of the range: ");
            //int start = int.Parse(Console.ReadLine());

            //Console.Write("Enter the end of the range: ");
            //int end = int.Parse(Console.ReadLine());

            //int a = 0, b = 1;
            //while (a <= end)
            //{
            //    if (a >= start)
            //    {
            //        Console.WriteLine(a);
            //    }
            //    int temp = a;
            //    a = b;
            //    b = temp + b;
            //}

            ////-------
            //Console.Write("Enter A: ");
            //int A = int.Parse(Console.ReadLine());

            //Console.Write("Enter B (B > A): ");
            //int B = int.Parse(Console.ReadLine());


            //for (int i = A; i <= B; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(i + " ");
            //    }
            //    Console.WriteLine();
            //}


            Console.WriteLine("Enter the length of the line:");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fill symbol:");
            char fillSymbol = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter the direction of the line \"H\" - horizontal/ \"V\" - vertical):");
            string direction = Console.ReadLine();

            if (direction == "H")
            {
                for (int i = 0; i < length; i++)
                {
                    Console.Write(fillSymbol);
                }
            }
            else if (direction == "V")
            {
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine(fillSymbol);
                }
            }
            else
            {
                Console.WriteLine("Invalid line direction specified.");
            }
        }
    }
}
