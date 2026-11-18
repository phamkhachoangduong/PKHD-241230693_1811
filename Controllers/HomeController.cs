using Microsoft.AspNetCore.Mvc;
using PKHD_241230693_1811.Models;
using System.Diagnostics;

namespace PKHD_241230693_1811.Controllers
{
    public class HomeController : Controller
    {
        private readonly PKHD_QLNhaSachContext _context;
        public HomeController(PKHD_QLNhaSachContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var ds = _context.Saches
                .Where(s => s.Gia !=null && s.Gia >=100)
                .ToList();
            return View(ds);
        }

        public IActionResult PKHD_LocTheotheLoai(int id)
        {
            var tl = _context.TheLoais.Find(id);
            if (tl == null) return NotFound();

            var ds = _context.Saches.Where(s => s.MaTL == id).ToList();
            ViewData["TieuDe"] = tl.TenTL;
            return PartialView("PKHD_MainContent", ds);
            
        }

      
    }
}
