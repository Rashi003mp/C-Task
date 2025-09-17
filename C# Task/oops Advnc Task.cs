using System;


namespace C__Task
{
    class Animal
    {
        public string Name;
        public int Age;

        public void speak()
        {
            Console.WriteLine($"Animal Name :{Name}, Animal Age : {Age}");
        }


    }
    class Dog : Animal
    {
        public string Breed;

    }

    class Cat : Animal
    {
        public void meow()
        {
            Console.WriteLine("Meow");
        }
    }

    class prgrm
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Name = "Tommy";
            dog.Age = 1;
            dog.Breed = "PitBull";
            dog.speak();

            Cat cat = new Cat();
            cat.Name = "Misty";
            cat.Age = 1;
            cat.speak();
            cat.meow();

        }
    }
}
