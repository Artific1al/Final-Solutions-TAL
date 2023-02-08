using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;

public static class Testing
{

    public static async Task CovidTestAsync()
    {
        await Task.Run(() => CovidTest());
    }
    public static void CovidTest()
    {
        Console.WriteLine("Please enter the query parameters for your API request to the https://vaccovid.live/ covid data api");
        Console.WriteLine("e.g. AUS / CAN / USA for last 6 months Australia / Canada / USA data");
        string input = Console.ReadLine();

        Uri endpoint = new Uri("https://vaccovid-coronavirus-vaccine-and-treatment-tracker.p.rapidapi.com/api/covid-ovid-data/sixmonth/" + input);
        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "9296e10be1msh81e2eb26de758dbp1b4f39jsnfc6fe3b066dd");
            client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "vaccovid-coronavirus-vaccine-and-treatment-tracker.p.rapidapi.com");
            var result = client.GetAsync(endpoint).Result.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
        }
        Console.WriteLine("bob");

    }
    // access token regenerates every 2 hours.


    public static string accessTokenWorkingMyabe = "https://api.meteomatics.com/2023-01-27T13:45:00.000+11:00/t_2m:C/51.5073219,-0.1276474/json?access_token=eyJ0eXAiOiJKV1QiLCJhbGciOiJFUzI1NiJ9.eyJ2IjoxLCJ1c2VyIjoidGFsbGlmZV9kYXZpZXMiLCJpc3MiOiJsb2dpbi5tZXRlb21hdGljcy5jb20iLCJleHAiOjE2NzQ3OTQ0NzAsInN1YiI6ImFjY2VzcyJ9.rENyWF7IrMNhwUPJRBpisOmsC_t4G3f1XfIpk3_yVYVlnhVvrM_T-mWMioL068ziDx8lHHUiqCOevourECyuhg";
    public static string accessToken = ("eyJ0eXAiOiJKV1QiLCJhbGciOiJFUzI1NiJ9.eyJ2IjoxLCJ1c2VyIjoidGFsbGlmZV9kYXZpZXMiLCJpc3MiOiJsb2dpbi5tZXRlb21hdGljcy5jb20iLCJleHAiOjE2NzQ3OTQ0NzAsInN1YiI6ImFjY2VzcyJ9.rENyWF7IrMNhwUPJRBpisOmsC_t4G3f1XfIpk3_yVYVlnhVvrM_T-mWMioL068ziDx8lHHUiqCOevourECyuhg");
    //2022-12-01T13:30:00.000+11:00--2023-01-27T13:30:00.000+11:00:P1D/t_2m:C/-37.8142176,144.9631608/json?model=mix
    public static void WeatherTest() // wont work after 2/2/23 as my trial user and pass expire then - also tokens ^^ expire every 2 hours
    {
        Console.WriteLine("Please enter the query parameters for your API request to the https://api.meteomatics.com/ weather data api");
        Console.WriteLine("(https://api.meteomatics.com/<YOUR INPUT>)");
        string input = Console.ReadLine();

        // Uri endpoint = new Uri("https://api.meteomatics.com/" + input + "access_token=" + accessToken);\
        Uri endpoint = new Uri(accessTokenWorkingMyabe);
        using (var client = new HttpClient())
        {
            var result = client.GetAsync(endpoint).Result.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
        }
        Console.WriteLine("bob");

    }

    /* public static void RetrieveAccessToken()
     {
         Uri endpoint = new Uri("https://login.meteomatics.com/api/v1/token");
         using (var client = new HttpClient())
         {
             // client.DefaultRequestHeaders.Add("User:", "tallife_davies");
             // client.DefaultRequestHeaders.Add("Password", "NK0JgS05vu");
             client.DefaultRequestHeaders.Add("Authorization", "bearer");
             client.DefaultRequestHeaders.Add("tallife_davies" + ":", "NK0JgS05vu");

             var result = client.GetAsync(endpoint).Result.Content.ReadAsStringAsync().Result;
             Console.WriteLine(result);
         }
         Console.WriteLine("bobby");
     }*/

}
