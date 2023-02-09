using System;


public class Games
{
    public Games(string inputTitle, int rating)
    {
        this.Title = inputTitle;
        this.Rating = rating;
        // this.Rating = rating;
    }

    public string Title
    { 
        get;
        set;
    }

    public int Rating
    {
        get;
        set;
    }
}