using System;
using System.Collections.Generic;
public class GameList 
{
    public GameList() { }

    readonly List<Games> originalList = new List<Games>()
    {
        new Games("Counter-Strike:", 8),
        new Games("Mario Kart:", 8),
        new Games("Super Smash Bros:", 6),
        new Games("League of Legends:", 4),
        new Games("Rocket League:", 5)
    };

    public bool cont;
    public bool hasSavedList = false;

    public List<Games> currentList = new List<Games>();

    public virtual List<Games> GenerateCurrList()
    {
        foreach (var game in originalList)
        {
            currentList.Add(game);
        }
        return currentList;
    }


}
