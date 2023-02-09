public static class Delete
{
    public static List<Games> PerformDelete(List<Games> games, int getValue)
    {
        games.Remove(games[getValue -1]);
        return games;
    }

}