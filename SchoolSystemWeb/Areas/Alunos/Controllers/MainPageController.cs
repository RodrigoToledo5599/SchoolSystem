using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Data.Data;
using SchoolSystem.Models.Models;

namespace SchoolSystemWeb.Areas.Alunos.Controllers
{
    public class MainPageController : Controller
    {
        public AppDbContext _db { get; set; }
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
