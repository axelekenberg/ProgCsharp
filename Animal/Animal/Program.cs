namespace Animal
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*Cat minKatt = new Cat(5);
            minKatt.Act();

            Dog minHund = new Dog(5);
            minHund.Act();*/

            Zoo minZoo = new Zoo();
            minZoo.Run();
        }
    }
}