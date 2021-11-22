using System;

namespace Uppgift8
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Uncomment the lines below when you've completed your implementations
            //PersonCreator consolePersonCreator = new AbstractClassA(); // Your code from part A here
            //consolePersonCreator.CreatePeople();

            PersonCreator filePersonCreator2 = new AbstractClassB(); // Your code from part B here
            filePersonCreator2.CreatePeople();
        }
    }
}
