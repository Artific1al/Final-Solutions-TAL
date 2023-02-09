using System;
using System.Collections.Generic;

public class SaveInfo : GameList
{
    public SaveInfo() { }

    public List<Games> SavedList = new List<Games>();
    public void SaveCurrentList()
    {
        foreach (var item in currentList)
        {
            SavedList.Add(item);
        }
    }

   /* public override List<Games> GenerateCurrList()
    {
        return SavedList;
    }*/

    
}