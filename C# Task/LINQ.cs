//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BasicPrograms
//{
//    internal class LINQ
//    {
//        int[] numbers = { 1, 2, 3, 4, 5, 6 };

//        // Query Syntax
//        public void Even()
//        {
//            var evenNumbers = from num in numbers
//                              where num % 2 == 0
//                              select num;
//            foreach (var n in evenNumbers)
//            {
//                Console.WriteLine(n);
//            }
//        }
//        // Method Syntax
//        public void Odd()
//        {
//            var Odd = numbers.Where(n => n % 2 != 0);

//            foreach (var n in Odd)
//            {
//                Console.WriteLine(n);
//            }
//        }
//    }
//     class Program 
//    { 
//        static void Main(string[] args)
//        {
//            LINQ linq = new LINQ();
//            linq.Even();
//            linq.Odd();
//        }
//    }
  

//}