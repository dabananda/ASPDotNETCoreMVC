using ASPDotNETCoreMVCWeb.Data;
using ASPDotNETCoreMVCWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPDotNETCoreMVCWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext applicationDbContext)
        {
            _db = applicationDbContext;
        }
        public IActionResult Index()
        {
            List<Category> categories = _db.Categories.ToList();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Add(category);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
