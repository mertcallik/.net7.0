using Microsoft.AspNetCore.Mvc;

namespace AspnetCoreMert.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Mertosum hos geldin suan index1'desin canimin içi";
        }

        public IActionResult Index2()
        {
            return View();
        }

        public string Index3()
        {
            return "Mertosum hos geldin suan index3'desin canimin içi";
        }
    }
}