using System.Collections.Generic;

namespace Animal
{
    internal class Zoo
    {
        public void Run()
        {
            foreach (Cat katt in cats)
            {
                katt.Act();
            }

            foreach (Dog hund in dogs)
            {
                hund.Act();
            }

            foreach (Cow ko in ko)
            {
                ko.Act();
            }
        }

        private List<Cat> cats;
        private List<Dog> dogs;
        private List<Cow> ko;

        public Zoo()
        {
            cats = new List<Cat>();
            cats.Add(new Cat(3));

            cats.Add(new Cat(3));

            cats.Add(new Cat(3));

            dogs = new List<Dog>();
            dogs.Add(new Dog(3));

            dogs.Add(new Dog(3));

            ko = new List<Cow>();
            ko.Add(new Cow(1));
            ko.Add(new Cow(1));
            

        }
    }
}