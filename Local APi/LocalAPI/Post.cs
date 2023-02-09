using System;
using System.Collections.Generic;

public static class Post
{
    public static List<Games> PerformPost(List<Games> example, string userGameInput, string ratingstring)
    {
        int rating = Convert.ToInt32(ratingstring);
            

       example.Add(new Games(userGameInput + ":", rating));
        return example;
    }
}
