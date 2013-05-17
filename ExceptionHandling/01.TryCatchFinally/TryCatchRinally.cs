using System;

class TryCatchFinally
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a number: ");
            string str = Console.ReadLine();
            int number = Int32.Parse(str);
            double squareRoot = Math.Sqrt(number);
            Console.WriteLine("The square root of {0} is equal to {1}", number, squareRoot);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (System.ArithmeticException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (System.ArgumentNullException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Goodbye!");
        }
    }
}