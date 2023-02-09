using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

public class APIController
{
    public APIController(string input) 
    {
        method = input.ToUpper();
    }

    string method;
    public bool validMethod = true;
    public int whichMethod = 0;
    // 1 = PUT
    // 2 = GET
    // 3 = POST
    // 4 = DELETE

    public string DetermineMethod(string method)
    {
        switch(method)
        {
            case ("PUT"):
                whichMethod = 1;
                return "PUT";
                break;
            case ("GET"):
                whichMethod = 2;
                return "GET";
                break;
            case ("POST"):
                whichMethod = 3;
                return "Post";
                break;
            case ("DELETE"):
                whichMethod = 4;
                return "DELETE";
                break;
            default:
                validMethod = false;
                return "Error: input is not of type GET, PUT, POST or DELETE" +
                    "\n\r Please try again";
                break;

        };
    }

   //public object PerformMethod(object input)
   // {
   //     if ((string)input == "GET")
   //     {
   //         Console.WriteLine("Which value would you like to get?");
   //         int num = Convert.ToInt32(Console.ReadLine());
   //         return GetMethod.PerformGet( num);
   //     }
   //     else
   //     {
   //         return "not implemented yet";
   //     }
   // }



    

   

}
