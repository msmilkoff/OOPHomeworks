using System;

namespace ClassesHomework
{
    class PersonClass
    {
        static void Main()
        {
            Person john = new Person("John", 25, "john@abv.bg");
            Person robb = new Person("Robb", 23);

            Console.WriteLine(john); // Console.WriteLine calls 'ToString' implicitly.
            Console.WriteLine();
            Console.WriteLine(robb);

            robb.Email = "robb@gmail.com";
            Console.WriteLine(robb.Email);
        }
    }
}
