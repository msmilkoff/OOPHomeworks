using System;

class Kitten : Cat, ISoundProducible
{
    private readonly string gender = "Female";

    public Kitten(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public Kitten(string name, int age, string gender)
        : base (name, age)
    {
        this.Gender = gender;
    }

    public Kitten()
    {
        
    }

    public string Gender
    {
        get { return this.gender; }
        private set { }
    }

    public void ProduceSound()
    {
        Console.WriteLine("{0}, the {1} said: Meaw!", this.Name, this.GetType());
    }
}
