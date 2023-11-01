using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Index()
        {

            return View();
        }
    }
}
