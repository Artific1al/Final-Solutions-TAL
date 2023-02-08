using System;
using System.Net.Http;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.IO;
public static class GetPost

{
    public static object ReturnPosts()
    {
        Console.WriteLine("Please enter the query parameters for your API request to https://jsonplaceholder.typicode.com/");
        Console.WriteLine("e.g. posts/1 for the first post, or comments?postId=8 for comments made by user 8");
        string input = Console.ReadLine();
     
        using (var client = new HttpClient())
        {
            var endpoint = new Uri($"https://jsonplaceholder.typicode.com/{input}");
            var result = client.GetAsync(endpoint).Result.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);

        }

        return "example object";
    }

    public static object ReturnPostsAsync()
    {
        Console.WriteLine("Please enter the query parameters for your API request to https://jsonplaceholder.typicode.com/");
        string input = Console.ReadLine();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            Stopwatch sw = Stopwatch.StartNew();
            Thread.Sleep(1000);
        }

        using (var client = new HttpClient())
        {
            var endpoint = new Uri($"https://jsonplaceholder.typicode.com/{input}");
            var result = client.GetAsync(endpoint).Result.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);

        }

        return "beep boop :3";
    }



}

