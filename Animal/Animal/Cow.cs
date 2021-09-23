using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Cow
    {
        public void Act()
        {
            for (int i = 0; i < age; ++i)
                Console.Write("Mu, Muu ");
            Console.WriteLine(" ");
        }

        private int age;

        public Cow(int a)
        {
            age = a;
        }
    }
}
