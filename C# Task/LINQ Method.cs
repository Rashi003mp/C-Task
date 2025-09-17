//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Task
//{
//    internal class LINQ_Method
//    {
//        class Employe
//        {
//            public int Id;
//            public string Name;
//            public string City;
//            public int Age;
//        }
//        class Salary
//        {
//            public int Id;
//            public int salary;
//        }
//        static void Main(string[] args)
//        {
//            List<Employe> employees = new List<Employe>
//            {
//                new Employe { Id = 1,Name ="aflah" , City ="Arizona" , Age=40},
//                new Employe { Id = 2,Name ="Ansif" , City ="Los angels" , Age=80},
//                new Employe { Id = 3,Name ="Fasil" , City ="Mars" , Age=200},
//                new Employe { Id = 4,Name ="Kooper" , City ="Mars" , Age=200 },
//            };

//            List<Salary> salaries = new List<Salary>
//            {
//                new Salary {Id = 1, salary = 10000 },
//                new Salary {Id = 1, salary = 70000 },
//                new Salary {Id = 3, salary = 80000 },
//                new Salary {Id = 4, salary = 50000 },
//            };

//            var Count = salaries.Count();
//            var sum = salaries.Sum(s => s.salary);
//            var ang = salaries.Average(s => s.salary);
//            var max = salaries.Max(s => s.salary);
//            var nearMax = salaries
//                .Where(s => s.salary != max)
//                .OrderBy(s => Math.Abs(s.salary - max))
//                .First();
//            var min = salaries.Min(s => s.salary);

//            Console.WriteLine($"amount near Max :{nearMax.salary} count :{Count} Total slarie : {sum} avarage salary : {ang}, Big salary : {max}, minimam salary : {min} ");

//            //var JoinedSalary = employees.Join(salaries,
//            //    e => e.Id,
//            //    s => s.Id,
//            //    (e, s) => new
//            //    {
//            //        e.Name,
//            //        s.salary,

//            //    });

//            //foreach (var e in JoinedSalary)
//            //{
//            //    Console.WriteLine($"{e.Name},{e.salary}");
//            //}


//            //var grouping = employees.GroupBy(e => e.Age).ToList();
//            //foreach (var group in grouping)
//            //{
//            //    Console.WriteLine(group.Key);
//            //    foreach (var i in group)
//            //    {
//            //        Console.WriteLine($"{i.Name},{i.City}");
//            //    }
//            //}

//            //var GroupByCity = employees.GroupBy(e => e.City);

//            //foreach (var i in GroupByCity)
//            //{
//            //    Console.WriteLine(i.Key);
//            //    foreach (var p in i)
//            //    {
//            //        Console.WriteLine($" name :{p.Name},{p.City}");
//            //    }
//            //}

//            //var MultiSorting = employees.OrderBy(e => e.City).ThenBy(e => e.Name);
//            //foreach (var employe in MultiSorting)
//            //{
//            //    Console.WriteLine($"{employe.Name},{employe.City}");
//            //}
//            //var sortedByAge = employees.OrderBy(s => s.Age);
//            //foreach (var empl in sortedByAge)
//            //{
//            //    Console.WriteLine(empl.Name); Console.WriteLine(empl.City);
//            //    Console.WriteLine(empl.Age);

//            //}
//            //var sortedByAge = employees.OrderByDescending(s => s.Age);
//            //foreach (var empl in sortedByAge)
//            //{
//            //    Console.WriteLine(empl.Name); Console.WriteLine(empl.City);
//            //    Console.WriteLine(empl.Age);

//            //}

//            //var adult = employees.Where( s => s.Age > 20 ) .ToList();
//            //foreach (var employe in adult)
//            //{
//            //    Console.WriteLine( employe.Name );
//            //}

//            //var names = employees.Select(s => s.Name).ToList();
//            //foreach (var per in names)
//            //{
//            //    Console.WriteLine(per);
//            //}

//            //var names1 = employees.SelectMany(s => s.Name).ToList();
//            //foreach (var per in names)
//            //{
//            //    Console.WriteLine(per);
//            //}

//            //var info = employees.Select(s => new { s.Name, s.Age }).ToList();
//            //foreach (var per in info)
//            //{
//            //    Console.WriteLine($"{per.Name},{per.Age}");
//            //}
//        }
//    }
//}
