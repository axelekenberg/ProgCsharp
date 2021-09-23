using System;

namespace Animal
{
    internal class Dog
    {
        public void Act()
        {
            for (int i = 0; i < age; ++i)
                Console.Write("vov, ");
            Console.WriteLine(" ");
        }

        private int age;

        public Dog(int a)
        {
            age = a;
        }
    }
}