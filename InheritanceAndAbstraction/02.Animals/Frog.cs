using System;

class Frog : Animal, ISoundProducible
{
    public Frog(string name, int age, string gender)
        :base(name ,age, gender)
    {
        
    }
    public Frog()
    {
        
    }

    public void ProduceSound()
    {
        Console.WriteLine("{0}, the {1} said: Croak!", this.Name, this.GetType());
    }
}
