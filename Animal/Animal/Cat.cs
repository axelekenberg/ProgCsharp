using System;

namespace Animal
{
    internal class Cat
    {
        public void Act()

        {
            for (int i = 0; i < age; ++i)
                Console.Write("mjau, ");
            Console.WriteLine(" ");
        }

        private int age;

        public Cat(int a)
        {
            age = a;
        }
    }
}