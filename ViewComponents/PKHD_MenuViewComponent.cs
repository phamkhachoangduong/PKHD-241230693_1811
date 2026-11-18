using Microsoft.AspNetCore.Mvc;
using PKHD_241230693_1811.Models;

namespace PKHD_241230693_1811.ViewComponents
{
    public class PKHD_MenuViewComponent : ViewComponent

    {
        private readonly PKHD_QLNhaSachContext _context;
        public PKHD_MenuViewComponent(PKHD_QLNhaSachContext context)
        {
            _context = context;
        }
       
        public IViewComponentResult Invoke()
        {
            var dsTheLoai = _context.TheLoais.OrderBy(t => t.MaTL).ToList();
            return View(dsTheLoai);
        }
    }
}
