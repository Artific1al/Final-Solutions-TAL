public static class Put
{
    public static List<Games> PerformPut(List<Games> example, int listValue, string gameTitle, string ratingValue)
    {
        example[listValue - 1].Title = gameTitle;
        example[listValue - 1].Rating = Convert.ToInt32(ratingValue);
        return example;
    }

}