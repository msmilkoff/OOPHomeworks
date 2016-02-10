using System;

class Cat : Animal, ISoundProducible
{
    private string name;
    private int age;

    public Cat(string name, int age, string gender)
        :base(name, age, gender)
    {
        
    }


    public Cat()
    {
        
    }

    public Cat(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void ProduceSound()
    {
        Console.WriteLine("{0}, the {1} said: Meaw!", this.Name, this.GetType());
    }
}
