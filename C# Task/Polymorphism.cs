//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BasicPrograms
//{
//    //compile time polymorphism
//    //Method Overloading
//    internal class Polymorphism
//    {
//        public int Add(int a, int b)
//        {
//            return a + b;
//        }
//        public int Add(int a, int b, int c)
//        {
//            return a + b + c;
//        }
//        public double Add(double a, double b)
//        {
//            return a + b;
//        }

//    }

//    // runtime polymorphism
//    public class Animal
//    {
//        public virtual void Speak()
//        {
//                       Console.WriteLine("Animal Sound");
//        }
//    }

//     class Dog : Animal
//    {
//        public override void Speak()
//        {
//            Console.WriteLine("Dog Barks");
//        }
//    }
//    class Cat : Animal
//    {
//        public override void Speak()
//        {
//            Console.WriteLine("Cat Meows");
//        }
//    }

//}
