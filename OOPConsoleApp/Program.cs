using System;

namespace OOPConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person userInfo = new Person();

            Console.WriteLine(userInfo.Info());

            Person me = new Person("Ulf", "Bengtsson", 38, Gender.Man);

            Console.WriteLine(me.Info());

        }
    }
}
