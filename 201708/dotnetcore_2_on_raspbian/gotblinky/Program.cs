using System;
using System.IO;
using System.Threading;

namespace gotblinky
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Singapore .NET CORE Developers!!!");
            Console.WriteLine("Let's do the blink!");
            var x = 0;
            while (true)
            {
                x = (x == 1) ? 0: 1;

                // about to open pin 26 - test if it's already open
                if (!Directory.Exists("/sys/class/gpio/gpio26"))
                {
                    Console.WriteLine("...about to open pin 26");
                    File.WriteAllText("/sys/class/gpio/export", "26");
                }
                else
                {
                    Console.WriteLine("...pin is already open");
                }

                Console.WriteLine("...specifying direction of Pin 26 as OUT");
                File.WriteAllText("/sys/class/gpio/gpio26/direction", "out");

                Console.WriteLine("...setting output level to " + x.ToString());
                File.WriteAllText("/sys/class/gpio/gpio26/value", x.ToString());
                Thread.Sleep(1000);
            }
        }
    }
}
