using System;

namespace OOPConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("new Person: " + Person.createdInstances);

            Person userInfo = new Person();

            Console.WriteLine("new Person: " + Person.createdInstances);

            Console.WriteLine(userInfo.Info());

            Person me = new Person("Ulf", "Bengtsson", 38, Gender.Man);

            Console.WriteLine("new Person: " + Person.createdInstances);
            
            Console.WriteLine(me.Info());

            userInfo.FirstName = "Tessan";

            Person[] people = new Person[] { me, userInfo };

            foreach (Person item in people)
            {
                Console.WriteLine(item);
            }

        }
    }
}
