﻿using System;

abstract class Human
{
    private string firstName;
    private string lastName;

    protected Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    protected Human()
    {
        
    }

    public string FirstName
    {
        get { return this.firstName; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("First name cannot be empty");
            }
            this.firstName = value;
        }
    }

    public string LastName
    {
        get { return this.lastName; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Last name cannot be null");
            }
            this.lastName = value;
        }
    }
}
