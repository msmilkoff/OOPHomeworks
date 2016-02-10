using System;

class SquareRoot
{
    static void Main()
    {
        try
        {
            uint input = uint.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(input));
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good Bye!");
        }
    }
}
