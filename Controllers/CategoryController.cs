using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class CategoryController : Controller
    {
        private readonly MongoDBservice _mongoDBservice;

        public CategoryController(MongoDBservice mongoDBservice)
        {
            _mongoDBservice = mongoDBservice;
        }

        public async Task<IActionResult> IndexAsync()
        {


            IEnumerable<Playlist> playlists = await _mongoDBservice.GetAsyncd();

            Console.WriteLine("kjklsjjdjkljdkjskldj", playlists);


            return View(playlists);

        }


        // public async IActionResult Get()
        //{

        //  var resuls = await _mongoDBservice.GetAsyncd();
        // return View();
        // }

        public async Task<IActionResult> Post(Playlist playlist)
        {
             await _mongoDBservice.CreateAsync(playlist);
            return View(playlist);
        }

    }
}