using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_10_2023
{
    public class DeviceChecker
    {
        public static void CheckDevice()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            bool penDriveFound = false;

            Console.Clear();
            Console.WriteLine("Wyszukiwanie nośników flash:");


            foreach (DriveInfo drive in drives)
            {
                if (drive.DriveType == DriveType.Removable)
                {
                    penDriveFound = true;
                    DeviceInfo.DisplayDeviceInfo(drive);
                }
            }

            if (!penDriveFound)
            {
                Console.WriteLine("Brak nośnika flash.");

            }

            Console.WriteLine("Naciśnij dowolny klawisz, aby powrócić do menu głównego...");

            Console.ReadKey();
        }
    }
}
