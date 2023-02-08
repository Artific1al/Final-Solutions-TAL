//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

public static class FakePost
{


    public static object Post()
    {
        using (var client = new HttpClient())
        {
            var endpoint = new Uri("https://jsonplaceholder.typicode.com/posts");
            Console.WriteLine("Please enter the information you wish to post to https://jsonplaceholder.typicode.com/posts");
            Console.WriteLine("Title: ");
            string Title = Console.ReadLine();
            Console.WriteLine("Body: ");
            string Body = Console.ReadLine();
            Console.WriteLine("UserId: ");
            string UserId = Console.ReadLine();
            var newPost = new string[] { $"Title: {Title}", $"Body: {Body}", $"UserId: {UserId}" };
            var newPostJson = newPost.ToString();
            var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");
            var result = client.PostAsync(endpoint, payload).Result.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);


            return "beep boop :3";
        }
    }


}
