using System;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Http;
public static class Files
{
    public static object ModifyFile()
    {
        string fileOutput = "C:\\Users\\adavis\\Downloads\\TAL_API_00-master\\TAL_API_00-working\\TAL_API\\OutputFile.txt";

        Console.WriteLine("This is where I'll print the weather info");
        Console.Write("Enter the URl that you want an html response from: ");
        string url = "https://" + Console.ReadLine();

        var awaiter = CallURL(url);
        if (awaiter.Result != null)
        {
            File.WriteAllText(fileOutput, awaiter.Result);
            Console.WriteLine("HTML response to " + fileOutput);
        }
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();

        return "beep boop :3";
    }



    public static async Task<string> CallURL(string url)
    {
        HttpClient client = new HttpClient();
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
        client.DefaultRequestHeaders.Accept.Clear();
        var response = client.GetStringAsync(url);
        return await response;
    }

}
