using System;

class EnterNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter 10 numbers between 1 and 100 in ascending order.");

        int start;
        const int end = 100;

        while (true)
        {
            try
            {
                start = int.Parse(Console.ReadLine());

                if (start <= 1 || start >= 100)
                {
                    throw new ArgumentOutOfRangeException();
                }

                break;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number. Try again");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number. Try again");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number. Try again");
            }
        }

        int successfulAttempts = 1;

        while (successfulAttempts < 10)
        {
            try
            {
                int next = ReadNumber(start, end);
                start = next;
                successfulAttempts++;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number. Try again");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number. Try again");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number. Try again");
            }
        }
    }

    public static int ReadNumber(int start, int end)
    {
        int number = int.Parse(Console.ReadLine());

        if (number < start || number > end)
        {
            throw new ArgumentOutOfRangeException();
        }

        return number;
    }
}
