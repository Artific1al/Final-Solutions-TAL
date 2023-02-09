public static class Run
{
    public static int ran = 0;

    public static int Ran
    {
        get { return ran; }
        set { ran = value; }
    }

    public static int TimesRan()
    {
        return ran;
    }

    public static List<Games> PreviousList = new List<Games>();

}