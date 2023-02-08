using System;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Http;
class RunMain
{
    public static void Main(string[] args)
    {
        //JsonStringConversion.CovidTest();
        GetPost.ReturnPosts();
        //Files.ModifyFile();
        //FakePost.Post();
        //Testing.WeatherTest();
        Testing.CovidTest();
        //Testing.RetrieveAccessToken();
    }
}
