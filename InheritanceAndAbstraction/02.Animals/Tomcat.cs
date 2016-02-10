using System;

class Tomcat : Cat, ISoundProducible
{
    private readonly string gender = "Male";

    public Tomcat(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public Tomcat(string name, int age, string gender)
        : base(name, age)
    {
        this.Gender = gender;
    }

    public Tomcat()
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
