using System;
using CarLibrary;

namespace CSharpCarClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** C# CarLibrary Client App ******");
            // Create object SportsCar
            SportsCar viper = new SportsCar("Viper", 240, 40);
            viper.TurboBoost();

            // Create object MiniVan
            MiniVan mv = new MiniVan();
            mv.TurboBoost();

            Console.WriteLine("Done. Press any key to terminate");
            Console.ReadLine();
        }
    }
}
