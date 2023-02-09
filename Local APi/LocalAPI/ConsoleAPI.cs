using System;
using System.Collections.Generic;
using System.Linq.Expressions;

public class ConsoleAPI
{
    public bool hasSavedList = false;
    static void Main(string[] args)
    {
        // below APIController is instantiated to make use of its method DetermineMethod
        int run = Run.TimesRan();
        
            var example = new GameList();
            example.currentList = Run.PreviousList;
            var save = new SaveInfo();
            
        if (run == 0)
        {
            example = new GameList();
            example.GenerateCurrList();
            
        }
        example.cont = true;

        Console.WriteLine("This API displays information about a game as Title: Rating / 10 \n\r");

        while (example.cont)
        {
            Console.WriteLine("This game API currently holds these games:");

            foreach (var item in example.currentList)
            {
                Console.WriteLine(item.Title + " " + item.Rating);
            }
            Console.WriteLine("There are currently " + example.currentList.Count +
                " values in the list");

            Console.WriteLine("\r\nWhat process would you like to perform?");
            Console.WriteLine("Type GET to get a value");
            Console.WriteLine("Type PUT to change a value");
            Console.WriteLine("Type DELETE to change a value");
            Console.WriteLine("Type POST to add a value\r\n");
            string firstInput = Console.ReadLine().ToUpper();
            Console.WriteLine("");

            var cont = new APIController(firstInput);
            string apiMethodResult = cont.DetermineMethod(firstInput);
            if (cont.validMethod)
            {
                switch(cont.whichMethod)
                {
                    case (1):
                        Console.WriteLine("What list value would you like to change?");
                        int listValue = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("What is the title of the replacement game?");
                        string gameTitle = Console.ReadLine();
                        Console.WriteLine("What is the rating of the replacement game:");
                        string RatingValue = Console.ReadLine();                      
                        Put.PerformPut(example.currentList, listValue, gameTitle, RatingValue);
                        Console.WriteLine("Updated! The game data has been changed.");
                        foreach (var item in example.currentList)
                        {
                            Console.WriteLine(item.Title + " " + item.Rating);
                        }
                        break;


                    case(2):
                        Console.WriteLine("What value in the list would you like to get?");
                        var input = Convert.ToInt32(Console.ReadLine());
                        if (input > example.currentList.Count || input < 0)
                        {
                            Console.WriteLine("Error: There is no game in the list of that value");
                            Console.WriteLine("Please try again");
                            break;
                        }
                        
                        else
                        {
                            var result = GetMethod.PerformGet(example.currentList, (int)input - 1);
                            Console.WriteLine(result);
                        }
                        break;
                    case(3):
                        Console.WriteLine("Please write the Game title to add");
                        var userGame = Console.ReadLine();
                        Console.WriteLine("Please write the rating for this game");
                        string rating = Console.ReadLine();
                        example.currentList = Post.PerformPost(example.currentList, userGame, rating);
                        Console.WriteLine("Updated! The current list is now:");
                        foreach (var item in example.currentList)
                        {
                            Console.WriteLine(item.Title + " " + item.Rating);
                        }
                        break;
                    case (4):
                        Console.WriteLine("Which game would you like to delete?");
                        int deleteVal = Convert.ToInt32(Console.ReadLine());
                        Delete.PerformDelete(example.currentList, deleteVal);
                        Console.WriteLine("Update! That game has been deleted!");
                        foreach (var item in example.currentList)
                        {
                            Console.WriteLine(item.Title + " " + item.Rating);
                        }
                        break;
                    default:
                        Console.WriteLine("Not implemented yet");
                        break;
                }
            }
            
            else
            {
                Console.WriteLine(apiMethodResult);
            }



            Console.WriteLine("\r\nWould you like to continue?");
            string lastInput = Console.ReadLine();
            if (lastInput == "y" || lastInput == "Y")
            {
                example.cont = true;
                Console.Clear();
            }
            else
            {
                example.cont = false;
            }
        }
        save.SaveCurrentList();
        Run.PreviousList = save.SavedList;
        example.hasSavedList = true;
        Run.Ran = 1;
        Console.WriteLine("Thanks for using our local game api.");
    }


}
