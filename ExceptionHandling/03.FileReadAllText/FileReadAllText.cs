using System;
using System.IO;
using System.Security;

class FileReadAllText
{
    static void ReadFilesContent(string filePath)
    {
        Console.WriteLine(filePath);
    }
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter the full path to file you want to be printed on console:");
            Console.WriteLine(@"Example: C:\Users\COBRA\Desktop\time.txt");
            string path = Console.ReadLine();
            string filePath = File.ReadAllText(path);
            ReadFilesContent(filePath);
        }
        catch (FileNotFoundException)
        {
            // pseudo-test: C:\Users\COBRA\Desktop\timelimit.txt
            Console.WriteLine("The file you specified could not be found.");
        }
        catch (ArgumentException)
        {
            //test: just press Enter
            Console.WriteLine("Please enter a valid file path.");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The specified path exceeds the system-defined maximum length.");
        }
        catch (DirectoryNotFoundException)
        {
            // pseudo-test: C:\Users\COBRA\Desktop\integers\time.txt
            Console.WriteLine("The specified file path could not be found.");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Unauthorized Access. You do not have permission to access this file.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("An Iinput/Output error occurred, while opening the file.");
        }
        catch (SecurityException)
        {
            Console.WriteLine("Security Issue. You do not have permission to access this file.");
        }
    }
}