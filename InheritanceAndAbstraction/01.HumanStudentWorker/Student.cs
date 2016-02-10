using System;

class Student : Human
{
    private string facultyNumber;

    public Student(string facultyNumber)
    {
        this.FacultyNumber = facultyNumber;
    }

    public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    public Student()
    {
        
    }

    public string FacultyNumber
    {
        get { return this.facultyNumber; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Faculty number cannot be null");
            }
            else if(value.Length < 5)
            {
                throw new ArgumentOutOfRangeException("Faculty number cannot be less than 5 characters long");
            }
            this.facultyNumber = value;
        }
    }

    public override string ToString()
    {
        return string.Format("{0} {1} - FN: {2}", this.FirstName, this.LastName, this.FacultyNumber);
    }
}
