using System;
using System.Collections.Generic;
using System.Linq;

class Animals
{
    private static void Main()
    {
        Animal[] animalArray =
        {
            new Dog("Lucky", 6, "Male"),
            new Dog("Bengy", 8, "Male"),
            new Cat("Leya", 3, "Female"),
            new Tomcat("Tom", 2),
            new Dog("Ronald", 7, "Male"),
            new Frog("Jerry", 2, "Male"),
            new Kitten("Samara", 1),
            new Tomcat("Bobby", 5),
            new Kitten("Yasmin", 3),
            new Frog("Princess", 9, "Female"),
            new Dog("Kosio", 12, "Male"),
            new Frog("Betty", 1, "Female")

        };
        Cat tomcat = new Tomcat("Robbie", 4);
        tomcat.ProduceSound();
        Console.WriteLine();

        List<Animal> animals = new List<Animal>();
        animals.AddRange(animalArray);

        double averageDogAge = animals
            .Where(x => x.GetType().ToString() == "Dog")
            .Select(x => x.Age)
            .Average();

        double averageCatAge = animals
            .Where(x => x.GetType().ToString() == "Cat" ||
                        x.GetType().ToString() == "Tomcat" ||
                        x.GetType().ToString() == "Kitten")
            .Select(x => x.Age)
            .Average();

        double averageFrogAge = animals
            .Where(x => x.GetType().ToString() == "Frog")
            .Select(x => x.Age)
            .Average();

        Console.WriteLine("Average Dog Age = " + averageDogAge);
        Console.WriteLine("Average Cat Age = " + averageCatAge);
        Console.WriteLine("Average Frog Age = " + averageFrogAge);
    }
}
