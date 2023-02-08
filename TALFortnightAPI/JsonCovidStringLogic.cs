using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using System.IO;

/*public static class JsonStringConversion : IEnumerable<Task<string>>
{
    public static Task<string> CovidTest(string input)
    {
        Uri endpoint = new Uri("https://vaccovid-coronavirus-vaccine-and-treatment-tracker.p.rapidapi.com/api/covid-ovid-data/" + input);
        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "9296e10be1msh81e2eb26de758dbp1b4f39jsnfc6fe3b066dd");
            client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "vaccovid-coronavirus-vaccine-and-treatment-tracker.p.rapidapi.com");
            var result = client.GetAsync(endpoint).Result.Content.ReadAsStringAsync();
            return result;
        }
    }
    public static void ModifyFile()
    {
        string fileOutput = "C:\\ILSource\\TALFortnightAPI\\CovidOutputFile.txt";

        Console.WriteLine("This is where I'll print the Covid Info");
        foreach (Task<string> item in CovidTest("sixmonth\\AUS")
            {

        }
        string url = "https://" + Console.ReadLine();

        var awaiter = CallURL(url);
        if (awaiter.Result != null)
        {
            File.WriteAllText(fileOutput, awaiter.Result);
            Console.WriteLine("HTML response to " + fileOutput);
        }
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
    }
}*/


