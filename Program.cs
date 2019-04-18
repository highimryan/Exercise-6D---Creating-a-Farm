using System;

namespace Exercise_6D___Creating_a_Farm
{
    internal class Farm
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("There are four animals on the farm!");

            Cow.Speak();
            Pig.Speak();
            Chicken.Speak();
            Horse.Speak();
        }
    }
}