using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class BasicOperations
    {
        public static void CheckOddEven(int number) 
        {
          if(number % 2 == 0)
           Console.WriteLine($"{number} is Even");
            else
                Console.WriteLine($"{number} is Odd");
        }
        public static void CheckNumberSign(int number)
        {
            if (number > 0)
                Console.WriteLine($"{number} is Positive");
            else if (number < 0)
                Console.WriteLine($"{number} is Negative");
            else
                Console.WriteLine($"{number} is Zero");
        } 
        public static void FindLargest(int a, int b, int c)
        {
            int largest;
            if (a >=b && a >= c)
                largest = a;
            else if (b >= a && b >= c)
                largest = b;
            else
                largest = c;
            
            Console.WriteLine($"LArgest number is {largest}");
       }
        public static void CheckLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0)|| year %400==0)
                Console.WriteLine($"{year} is a Leap Year");
            else
                Console.WriteLine($"{year} is not a Leap Year");
        }
        public static void FindGrade(int grade)
        {
            if (grade >= 90 && grade <= 100)
                Console.WriteLine($"S grade{grade}");
            else if (grade >= 80 && grade <= 90)
                Console.WriteLine($"A grade{grade}");
            else if (grade >= 70 && grade <= 80)
                Console.WriteLine($"B grade{grade}");
            else if (grade >= 60 && grade <= 70)
                Console.WriteLine($"C grade{grade}");
            else if (grade >= 50 && grade <= 60)
                Console.WriteLine($"D grade{grade}");
            else if (grade >= 40 && grade <= 50)
                Console.WriteLine($"E grade{grade}");
            else if (grade >= 0 && grade <= 40)
                Console.WriteLine($"Studen has failed {grade}");
            else 
                Console.WriteLine("Invalid grade");
        }
        public static bool IsPrime(int num)
        {
            if (num <= 1) return false; 

            if (num <= 3) return true;  

            if (num % 2 == 0 || num % 3 == 0)
                return false;

            for (int i = 5; i * i <= num; i += 6)
            {
                if (num % i == 0 || num % (i + 2) == 0)
                    return false;
            }

            return true;
        }


    }
}
