using Microsoft.AspNetCore.Mvc;

namespace ASPDotNETCoreMVCWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
