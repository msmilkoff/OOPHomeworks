using System;

class Dog : Animal, ISoundProducible
{
    public Dog(string name, int age, string gender)
        : base(name, age, gender)
    { 
    }

    public Dog()
    {
        
    }

    public void ProduceSound()
    {
        Console.WriteLine("{0}, the {1} said: Bark!",
            this.Name, this.GetType());
    }
}
