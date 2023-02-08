using System;
using System.Threading.Tasks;
    internal class Program
    {
        public static void Bob()
        {
            var result = LongProcess();
        Console.WriteLine(result);
        ShortProcess();
        Console.WriteLine("I should get printted first");
            Console.ReadLine();
        }
        static async Task<string> LongProcess()
        {
            Console.WriteLine("LongProcess Started"); await Task.Delay(5000); // hold execution for 100 seconds   
        Console.WriteLine("LongProcess Completed");             return "AL";
        }
        static async void ShortProcess()
        {
            Console.WriteLine("ShortProcess Started"); await Task.Delay(1000);
        //do something here     
        Console.WriteLine("ShortProcess Completed");             
        }
    }
