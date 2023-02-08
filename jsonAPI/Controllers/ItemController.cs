using jsonAPIproject.Repository;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

[ApiController]
[Route("[controller]")]
public class ItemController : ControllerBase
{
    //private readonly IItemRepository itemRepository;

    //public ItemController(IItemRepository itemRepository)
    public ItemController()
    {
        //this.itemRepository = itemRepository;
    }

    [HttpGet]
    public async Task<List<Item>>Get()
    {
        using (var client = new HttpClient())
        {
            var endpoint = new Uri($"https://jsonplaceholder.typicode.com/posts");
            var response = await client.GetAsync(endpoint);

            if (!response.IsSuccessStatusCode)
            {
                return null!;
            }

            var result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Item>>(result)!;

        }
    }

}
