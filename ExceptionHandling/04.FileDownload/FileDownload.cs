using System;
using System.Net;
using System.Security;

class FileDownload
{
    static void Main()
    {
        string link = "http://www.devbg.org/img/Logo-BASD.jpg";
        string file = "Logo-BASD.jpg";

        using (WebClient myClient = new WebClient())
        {
            try
            {
                myClient.DownloadFile(link, file);
                Console.WriteLine(@"The file is downloaded in project subfolder ...\04.FileDownload\bin\debug");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The web-address name is either empty, or read as empty. Please provide a valid address.");
            }
            catch (WebException)
            {
                Console.WriteLine("The web-address was not found. ");
                Console.WriteLine("Please make sure the address is correct.");
                Console.WriteLine("Please check your network connection.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("This operation is already performed by another method.");
            }
            catch (SecurityException)
            {
                Console.WriteLine("Security Issue. You do not have permission to access this file.");
            }
        }

    }
}