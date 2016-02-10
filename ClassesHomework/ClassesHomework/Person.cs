using System;

namespace ClassesHomework
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new FormatException("Name cannot be empty.");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0 && value > 100)
                {
                    throw new ArgumentOutOfRangeException("Age must be positive integer between 0 and 100");
                }
                this.age = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value == null || !value.Contains("@"))
                {
                    throw new FormatException("Email is not in correct format");
                }
                this.email = value;
            }
        }

        public override string ToString()
        {
            string email = string.IsNullOrEmpty(this.email) ? "[no e-mail]" : this.email;

            return string.Format(
                "Hello! My name is {0} and I'm {1} years old. Email: {2}",
                this.Name, this.Age, this.Email
                );
        }
    }
}
