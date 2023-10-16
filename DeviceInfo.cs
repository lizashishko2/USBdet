using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_10_2023
{


    public class DeviceInfo
    {
        public static void DisplayDeviceInfo(DriveInfo drive)
        {
            Console.WriteLine("Znaleziono dysk flash:");
            Console.WriteLine("Nazwa dysku: " + drive.Name);
            Console.WriteLine("Typ dysku: " + drive.DriveType);
            Console.WriteLine("Dostępna przestrzeń: " + drive.AvailableFreeSpace);
            Console.WriteLine("Całkowity rozmiar dysku: " + drive.TotalSize);
            Console.WriteLine();
        }
    }
}
