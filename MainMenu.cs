using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_10_2023
{
    public class MainMenu
    {
        public static void DisplayMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu główne:");
                Console.WriteLine("1. Naciśnij 'A', aby sprawdzić urządzenie.");
                Console.WriteLine("2. Naciśnij 'Q', aby wyjść.");

                char key = Console.ReadKey().KeyChar;

                if (key == 'A' || key == 'a')
                {
                    DeviceChecker.CheckDevice();
                }
                else if (key == 'Q' || key == 'q')
                {
                    Console.WriteLine("\nDo widzenia!");
                    break;
                }
                Console.ReadLine();
            }
        }
    }
}
