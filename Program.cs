using System;
using System.Runtime.InteropServices;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("le byte retourné est :  " + currentdeviceindex());
            Console.WriteLine(NLIsConfigLoaded());
        }
        [DllImport("USBCMS.dll")]
        public extern static byte NLIsConfigLoaded();
        [DllImport("USBIICMS.dll")]
        public extern static uint currentdeviceindex();
    }
}
