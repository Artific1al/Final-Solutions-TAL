using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;




public class CovidData
{
    public static void CovidResponse()
    {
        Console.WriteLine("Please enter the query parameters for your API request to the https://vaccovid.live/ covid data api");
        Console.WriteLine("(https://vaccovid-coronavirus-vaccine-and-treatment-tracker.p.rapidapi.com/api/api-covid-data/<YOUR INPUT>)");
        string input = Console.ReadLine();

        Uri endpoint = new Uri("https://vaccovid-coronavirus-vaccine-and-treatment-tracker.p.rapidapi.com/api/api-covid-data/" + input);
        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "9296e10be1msh81e2eb26de758dbp1b4f39jsnfc6fe3b066dd");
            client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "vaccovid-coronavirus-vaccine-and-treatment-tracker.p.rapidapi.com");
            var result = client.GetAsync(endpoint).Result.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
        }
    }
    public static async Task<string> CovidInfoTask(string countryCode)
    {
        var client = new HttpClient();
        Uri RequestUri = new Uri($"https://vaccovid-coronavirus-vaccine-and-treatment-tracker.p.rapidapi.com/api/api-covid-data/reports/{countryCode}");
        
        client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "9296e10be1msh81e2eb26de758dbp1b4f39jsnfc6fe3b066dd");
        client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "vaccovid-coronavirus-vaccine-and-treatment-tracker.p.rapidapi.com");

        
        var response = client.GetAsync(RequestUri).Result;
        var print = await response.Content.ReadAsStringAsync();
        Console.WriteLine(print);
        
        
        return print;
    }

   public static async Task Timmy(Uri input)
    {
        using (HttpClient client = new HttpClient())
        {
            Console.WriteLine(await client.GetAsync(input).Result.Content.ReadAsStringAsync());
      }
    }
        


    
}