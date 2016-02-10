using System;
using System.Globalization;

class Worker : Human
{
    private double weekSalary;
    private double workHoursPerDay;

    public Worker(double weekSalary, double workHoursPerDay)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public Worker()
    {
        
    }

    public double WeekSalary
    {
        get { return this.weekSalary; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Salary cannot be negative");
            }
            this.weekSalary = value;
        }
    }

    public double WorkHoursPerDay {
        get { return this.workHoursPerDay; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Work hours cannot be negative");
            }
            this.workHoursPerDay = value;
        }
    }

    public double MoneyPerHour()
    {
        return this.weekSalary / (this.workHoursPerDay * 5); // Five-day work-week.
    }

    public override string ToString()
    {
        var us = new CultureInfo("en-US");

        return string.Format("{0} {1}, Payment: {2}",
            this.FirstName, this.LastName, this.MoneyPerHour().ToString("c", us));
    }
}
