using System;

namespace Codecool.LifeOfAnts
{
    /// <summary>
    ///     Simulation main class
    /// </summary>
    public static class Program
    {
        /// <summary>
        ///     Main method
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Press ENTER to move the ants!");
            var colony = new Colony(15);
            colony.GenerateAntColony(4, 2, 2);
            colony.Display();
            string input = "";
            while (input != "q")
            {
                input = Console.ReadLine();
                if (input == "")
                {
                    Console.Clear();
                    Console.WriteLine("User pressed \"Enter\"");
                    colony.Update();
                    colony.Display();
                }
            }
            Console.WriteLine("See you next time!");
        }
    }
}
