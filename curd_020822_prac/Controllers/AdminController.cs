using curd_020822_prac.Models;
using Microsoft.AspNetCore.Mvc;

namespace curd_020822_prac.Controllers
{
    public class AdminController : Controller
    {
        private readonly DatabaseContext _db;

        public AdminController(DatabaseContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var data = _db.tblEmployees.ToList();
            return View(data);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(TblEmployee _emp)
        {
            _db.tblEmployees.Add(_emp);
            _db.SaveChanges();
            return View("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var data = _db.tblEmployees.Where(x =>x.Id == id).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(TblEmployee _emp)
        {
            var data=_db.tblEmployees.Update(_emp);
            _db.SaveChanges();
            return View(data);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = _db.tblEmployees.Where(x => x.Id == id).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public IActionResult Delete(TblEmployee _emp)
        {
            var data = _db.tblEmployees.Remove(_emp);
            _db.SaveChanges();
            return View(data);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var data = _db.tblEmployees.Where(x => x.Id == id).FirstOrDefault();
            return View();
        }
    }
}
