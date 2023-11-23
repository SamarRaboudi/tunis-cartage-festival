using FestivalCartage.Data;
using FestivalCartage.Models;
using Microsoft.AspNetCore.Mvc;

namespace FestivalCartage.Controllers
{
    public class ConcertController : Controller
    {

        private readonly ApplicationDbContext _db;


        public ConcertController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Concert> objConcertList = _db.Concert;

            return View(objConcertList);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Concert obj)
        {
            if (obj.concertDate == null)
            {
                ModelState.AddModelError("concetDate", "The ConcertDate is required.");
            }
            if (ModelState.IsValid)
            {
                _db.Concert.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
           
         return View(obj);
        }

        //GET
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0) 
            {
                return NotFound();
            }
            var concertFoundDb = _db.Concert.Find(id);
            if(concertFoundDb == null) 
            { 
                return NotFound(); 
            }
            return View(concertFoundDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Concert obj)
        {
            if (ModelState.IsValid)
            {
                _db.Concert.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }

       

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Concert.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            _db.Concert.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
            
        }
    }
}
