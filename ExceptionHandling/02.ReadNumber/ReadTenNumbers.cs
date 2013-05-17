using System;

class ReadTenNumbers
{
    static void Main()
    {
        Console.WriteLine("This program reads 10 number in the interval (1..100)\n" +
            "each entered number should be greater than the previous.");
        int n = 1;
        try
        {
            for (int i = 1; i <= 10; i++)
            {
                n = ReadNumber(n, 100, i);
            }
        }
        catch (System.FormatException)
        {
            Console.WriteLine("Not an integer number.");
        }
        catch (System.OverflowException)
        {
            Console.WriteLine("Not in the scope of integer.");
        }
        catch (System.ArgumentNullException)
        {
            Console.WriteLine("Null is not an integer number.");
        }
        catch (System.ArgumentOutOfRangeException)
        {
            Console.WriteLine("The entered number is not in range.");
        }
    }
    static int ReadNumber(int start, int end, int number)
    {
        int n = 1;
        Console.Write("Enter number {0}: ", number);
        n = int.Parse(Console.ReadLine());
        if (n < start || end < n)
        {
            throw new System.ArgumentOutOfRangeException();
        }
        return n;
    }
}