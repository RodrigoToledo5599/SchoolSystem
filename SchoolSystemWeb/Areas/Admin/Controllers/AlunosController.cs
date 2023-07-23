using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Data.Data;
using SchoolSystem.Models.Models;

namespace SchoolSystemWeb.Areas.Admin.Controllers
{
    public class AlunosController : Controller
    {
        public AppDbContext _db { get; set; }

        public AlunosController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var alunos = _db.Alunos.ToList();
            return View(alunos);
        }
    }
}
