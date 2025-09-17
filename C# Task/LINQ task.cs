//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BasicPrograms
//{
//    class student
//    {
//        public int Id;
//        public string Name;
//        public int Age;
//    }
//    class grade
//    {
//        public int Id;
//        public string Name;
//        public int marks;
//    }



//    class progm
//    {
//        static void Main(string[] args)
//        {
//            List<student> obj = new List<student>
//            {
//                new student { Id = 2,Name="ansif",Age=18},
//                new student { Id = 1,Name="fasil",Age=16},
//                new student { Id = 3,Name="aflah",Age=19},
//                new student { Id = 4,Name="arban",Age=22},
//            };

//            List<grade> obj1 = new List<grade>
//            {
//                new grade {Id=1 , marks = 40 },
//                new grade {Id=2 , marks = 70 },
//                new grade {Id=3 , marks = 50 },
//                new grade {Id=4 , marks = 10 },
//            };

//            var isAdult = from s in obj 
//                          let adults = s.Age > 18
//                          where adults
//                          select new { s.Name, s.Age };

//            foreach (var i in isAdult)
//            {
//                Console.WriteLine($"{i.Age} , { i.Name}");
//            }

            //var JionMarks = from s in obj
            //                join m in obj1
            //                on s.Id equals m.Id
            //                select new { s.Name, m.marks };

            //foreach (var g in JionMarks)
            //{
            //    Console.WriteLine($"Name :{g.Name} , Mark : {g.marks}");
            //}


            //var AgeGroup = from s in obj
            //               group s by s.Age into g
            //               select new
            //               {
            //                   age = g.Key,
            //                   Count = g.Count(),
            //               };
            //foreach (var r in AgeGroup)
            //{
            //    Console.WriteLine($"age : {r.age},Count :{r.Count}");
            //}

            //var res = from s in obj
            //          select s;
            //foreach (var s in res)
            //{
            //    Console.WriteLine($"Id:{s.Id} Name:{s.Name} Age:{s.Age}");
            //}
            //var res1 = from s in obj
            //           where s.Age > 20
            //           select s;
            //foreach (var s in res1)
            //{
            //    Console.WriteLine($"res1 =  Id:{s.Id} Name:{s.Name} Age:{s.Age}");
            //}
            //var ageorder = from s in obj
            //               orderby s.Age
            //               select s;

            //foreach (var s in ageorder)
            //{
            //    Console.WriteLine($"age order =  Id:{s.Id} Name:{s.Name} Age:{s.Age}");
            //}
//        }
//    }


//}
