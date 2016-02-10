using System;
using System.Collections.Generic;
using System.Linq;

class HumanStudentWorker
{
    private static void Main()
    {
        var students = new List<Student>();
        Student[] studentsArraay = 
        {
            new Student("Peter", "Peshev", "01525212"),
            new Student("Georgi", "Georgiev", "17825212"),
            new Student("Vasil", "Petrov", "65425212"),
            new Student("Petko", "Rusev", "2285212"),
            new Student("Diana", "Koleva", "44525212"),
            new Student("Vladimir", "Dobrev", "85325212"),
            new Student("Kaloyan", "Krustev", "654525212"),
            new Student("Rosen", "Mladenov", "9879525212"),
            new Student("Maria", "Nikolaeva", "213525212"),
            new Student("Ekaterina", "Vasileva", "334525212")
        };

        students.AddRange(studentsArraay);

        var orderedStudents = students.OrderBy(x => x.FacultyNumber);

        Console.WriteLine("Students:");
        Console.WriteLine("\t" + string.Join(" \n\t", orderedStudents));
        Console.WriteLine();

        List<Worker> workers = new List<Worker>()
        {
            new Worker("John", "Doe", 500.50, 10),
            new Worker("Bill", "Smith", 765, 8),
            new Worker("Jane", "Hendrix", 1556, 8),
            new Worker("Liam", "Brody", 1118, 8),
            new Worker("Peter", "Ross", 995, 4),
            new Worker("George", "Gibbs", 878, 8),
            new Worker("Ronald", "Foley", 500, 10),
            new Worker("Rose", "Michaels", 1054, 8),
            new Worker("Jenny", "O'shea", 629, 4),
            new Worker("Bell", "McBright", 755, 10)
        };

        var orderedWorkers = workers.OrderByDescending(x => x.MoneyPerHour());

        Console.WriteLine("Workers:");
        Console.WriteLine("\t" + string.Join(" \n\t", orderedWorkers));

        var people = orderedWorkers
            .Concat<Human>(orderedStudents)
            .ToList()
            .OrderBy(x => x.FirstName)
            .ThenBy(y => y.LastName);

        Console.WriteLine("\nAll:");
        foreach (Human person in people)
        {
            Console.WriteLine("\t{0} ({1})", person, person.GetType());
        }
    }
 }
