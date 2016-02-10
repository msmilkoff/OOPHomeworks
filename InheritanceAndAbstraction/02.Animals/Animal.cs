using System;

abstract class Animal
{
    private string name;
    private int age;
    private string gender;

    protected Animal(string name, int age, string gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    protected Animal()
    {
        
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Name cannot be empty.");
            }
            this.name = value;
        }
    }

    public int Age

    {
        get { return this.age; }
        set
        {
            if (value <= 0 )
            {
                throw new ArgumentOutOfRangeException("Age must be a positive number");
            }
            this.age = value;
        }
    }

    public string Gender {
        get { return this.gender; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Animals must have gender");
            }
            this.gender = value;
        }
    }
}
