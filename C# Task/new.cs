//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Task
//{
//    class student
//    {
//        public string Name;
//        public int Marks;

//    };

//    class prgrm
//    {
//        static void Main(string[] args)
//        {
//            List<student> students = new List<student>
//            {
//                new student { Name = "fasil", Marks = 20 },
//                new student { Name = "farhan", Marks = 30 },
//                new student { Name = "malik", Marks = 40 },
//                new student { Name = "erik", Marks = 50 },
//            };

//            var secondnum = students
//                .OrderByDescending(s => s.Marks)
//                .Skip(0)
//                .FirstOrDefault();

//            Console.WriteLine($"Student with the second highest marks: {secondnum.Name}, Marks: {secondnum.Marks}");










//        }

//    }
//}
