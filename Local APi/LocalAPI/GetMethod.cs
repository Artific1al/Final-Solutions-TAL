using System;
using System.Collections.Generic;

public static class GetMethod
{
    static GetMethod() { }

    public static string PerformGet(List<Games> example, int getValue)
    {
        int leng = example.Count;

        if (getValue <= leng)
        {
            var result = example[getValue];
            return (result.Title + " " + result.Rating);
        }
        else
        {
            return ("Error: value was not found in list of game data. Please try again");
        }
    }

}


