using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
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
            /*
            Console.WriteLine("It's easy to win forgiveness for being wrong;\nbeing right is what gets you into real trouble.\nBjarne Stroustrup");

            double[] numbers = new double[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter the number: ");
                numbers[i] = double.Parse(Console.ReadLine());
            }

            double sum = 0;
            foreach (double number in numbers)
            {
                sum += number;
            }

            double max = numbers[0];
            double min = numbers[0];
            for (int i = 1; i < 5; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            double productNumbers = 1;
            foreach (double number in numbers)
            {
                productNumbers *= number;
            }

            Console.WriteLine("Sum of numbers: " + sum);
            Console.WriteLine("Maximum: " + max);
            Console.WriteLine("Minimum: " + min);
            Console.WriteLine("Product of numbers: " + productNumbers);

            //-----

            Console.Write("Enter a six-digit number: ");
            int num = int.Parse(Console.ReadLine());

            int reversedNum = 0;

            while (num > 0)
            {
                int remainder = num % 10;
                reversedNum = (reversedNum * 10) + remainder;
                num /= 10;
            }

            Console.WriteLine("Result: " + reversedNum);

            //------

            Console.Write("Enter the start of the range: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter the end of the range: ");
            int end = int.Parse(Console.ReadLine());

            int a = 0, b = 1;
            while (a <= end)
            {
                if (a >= start)
                {
                    Console.WriteLine(a);
                }
                int temp = a;
                a = b;
                b = temp + b;
            }

            //-------
            Console.Write("Enter A: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Enter B (B > A): ");
            int B = int.Parse(Console.ReadLine());

            

            for (int i = A; i <= B; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

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

            
             
             */
            //1

            Console.Write("Enter a number from 1 to 100: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 1 || number > 100)
            {
                Console.WriteLine("Error: The number must be between 1 and 100.");
            }
            else if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }

            //2

            Console.WriteLine("Enter a number:");
            double num = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a percentage:");
            double percentage = double.Parse(Console.ReadLine());

            double result = (percentage / 100) * num;

            Console.WriteLine($"{percentage}% of {num} equals {result}.");

            //3

            Console.WriteLine("Enter the first digit:");
            int digit1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second digit:");
            int digit2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third digit:");
            int digit3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fourth digit:");
            int digit4 = int.Parse(Console.ReadLine());

            int Num = digit1 * 1000 + digit2 * 100 + digit3 * 10 + digit4;

            Console.WriteLine($"Formed number: {Num}");

            //4

            Console.WriteLine("Enter a six-digit number:");
            int numb = int.Parse(Console.ReadLine());

            int[] digits = new int[6];
            for (int i = 5; i >= 0; i--)
            {
                digits[i] = numb % 10;
                numb /= 10;
            }

            Console.WriteLine("Enter the positions of the digits to swap (e.g., 1 and 6):");
            int position1 = int.Parse(Console.ReadLine());
            int position2 = int.Parse(Console.ReadLine());

            int temp = digits[position1 - 1];
            digits[position1 - 1] = digits[6 - position2];
            digits[6 - position2] = temp;

            int res = 0;
            for (int i = 0; i < 6; i++)
            {
                res = res * 10 + digits[i];
            }

            Console.WriteLine($"Result: {res}");

            //5
            Console.WriteLine("Enter the date (in format DD.MM.YYYY):");
            string input = Console.ReadLine();

            if (DateTime.TryParseExact(input, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                string season;

                switch (date.Month)
                {
                    case 12:
                    case 1:
                    case 2:
                        season = "Winter";
                        break;
                    case 3:
                    case 4:
                    case 5:
                        season = "Spring";
                        break;
                    case 6:
                    case 7:
                    case 8:
                        season = "Summer";
                        break;
                    case 9:
                    case 10:
                    case 11:
                        season = "Autumn";
                        break;
                    default:
                        season = "";
                        break;
                }

                string dayOfWeek = date.ToString("dddd", CultureInfo.GetCultureInfo("en-US"));

                Console.WriteLine($"{season} {dayOfWeek}");
            }
            else
            {
                Console.WriteLine("Invalid date format.");
            }

            //6
            Console.WriteLine("Choose conversion option:");
            Console.WriteLine("1. Fahrenheit to Celsius");
            Console.WriteLine("2. Celsius to Fahrenheit");

            string choice = Console.ReadLine();

            double temperature;
            double convertedTemperature;

            if (choice == "1")
            {
                Console.WriteLine("Enter temperature in Fahrenheit:");
                temperature = double.Parse(Console.ReadLine());

                convertedTemperature = (temperature - 32) * 5 / 9;

                Console.WriteLine($"Temperature in Celsius: {convertedTemperature:F2} °C");
            }
            else if (choice == "2")
            {
                Console.WriteLine("Enter temperature in Celsius:");
                temperature = double.Parse(Console.ReadLine());

                convertedTemperature = temperature * 9 / 5 + 32;

                Console.WriteLine($"Temperature in Fahrenheit: {convertedTemperature:F2} °F");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }

            //7
            Console.WriteLine("Enter two numbers:");

            Console.Write("First number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Second number: ");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                int Temp = number1;
                number1 = number2;
                number2 = Temp;
            }

            Console.WriteLine($"Even numbers in the range from {number1} to {number2}:");
            for (int i = number1; i <= number2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
