using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PKHD_241230693_1811.Models;

namespace PKHD_241230693_1811.Controllers
{
    public class PKHD_SachController : Controller
    {
        private readonly PKHD_QLNhaSachContext _context;
        public PKHD_SachController(PKHD_QLNhaSachContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.MaTL = new SelectList(_context.TheLoais, "MaTL", "TenTL");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("MaTL,TenSach,Gia,Anh")] Sach sach)
        {
            if (ModelState.IsValid)
            {
                _context.Saches.Add(sach);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            ViewBag.MaTL = new SelectList(_context.TheLoais, "MaTL", "TenTL", sach.MaTL);
            return View(sach);
        }
    }
}